using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application.Interfaces;
using Restaurante.Application.Service;
using Restaurante.Application.ViewModel;
using Restaurante.Domain.Entities;

namespace Restaurante.Web.Controllers
{
    public class ClienteController : Controller
    {
        public readonly IClienteApp _clienteApp;

        public ClienteController(IClienteApp clienteApp) : base()
        {
            _clienteApp = clienteApp;
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View(_clienteApp.ListarTodos());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_clienteApp.PesquisarPorId(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create([FromBody]List<ClienteViewModel> cliente)
        {
            try
            {
                // TODO: Add insert logic here
                _clienteApp.Cadastrar(cliente.FirstOrDefault());

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_clienteApp.PesquisarPorId(id));
        }


        [HttpGet]
        public JsonResult CarregarDetalhes(Guid id)
        {
            //var id = new Guid("B46F5532-F947-4FC2-8195-08D817A9E0EC");
            var cliente = _clienteApp.PesquisarPorId(id);
            return Json(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromBody]List<ClienteViewModel> cliente)
        {
            try
            {
                // TODO: Add update logic here
                _clienteApp.Atualizar(cliente.FirstOrDefault());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_clienteApp.PesquisarPorId(id));
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteViewModel cliente)
        {
            try
            {
                // TODO: Add delete logic here
                _clienteApp.Excluir(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public JsonResult InsertCustomers([FromBody]List<ClienteViewModel> customers)
        {
            return Json("");
        }

    }
}