using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application.Interfaces;
using Restaurante.Application.ViewModel;

namespace Restaurante.Web.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IPedidoApp _pedidoApp;
        private readonly IClienteApp _clienteApp;
        private readonly IRefeicaoApp _refeicaoApp;
        private readonly IAdicionalApp _adicionalApp;

        public PedidoController(IPedidoApp pedidoApp, IClienteApp clienteApp, IRefeicaoApp refeicaoApp, IAdicionalApp adicionalApp)
        {
            _pedidoApp = pedidoApp;
            _clienteApp = clienteApp;
            _refeicaoApp = refeicaoApp;
            _adicionalApp = adicionalApp;
        }
        // GET: PedidoController
        public ActionResult Index(Guid idCliente)
        {
            var pedidos = _pedidoApp.ListarPedidosPorCliente(idCliente);
            return View();
        }

        // GET: PedidoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PedidoController/DetailsCliente/5
        public ActionResult DetailsCliente(Guid  idCliente)
        {
            return View();
        }


        // GET: PedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PedidoViewModel pedido)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PedidoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public JsonResult CarregarDetalhesUsuario(Guid id)
        {
            var cliente = _clienteApp.PesquisarPorId(id);
            return Json(cliente);
        }

        public JsonResult CarregarRefeicoes()
        {
            var refeicao = _refeicaoApp.ListarTodos();
            return Json(refeicao);
        }

        public JsonResult CarregarAdicionais()
        {
            var adicional = _adicionalApp.ListarTodos();
            return Json(adicional);
        }

    }
}
