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
    public class AdicionalController : Controller
    {
        private readonly IAdicionalApp _adicionalApp;
        public AdicionalController(IAdicionalApp adicionalApp   )
        {
            _adicionalApp = adicionalApp;
        }
        // GET: AdicionalController
        public ActionResult Index()
        {
            return View(_adicionalApp.ListarTodos());
        }

        // GET: AdicionalController/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_adicionalApp.PesquisarPorId(id));
        }

        // GET: AdicionalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdicionalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdicionalViewModel adicional)
        {
            try
            {
                _adicionalApp.Cadastrar(adicional);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdicionalController/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_adicionalApp.PesquisarPorId(id));
        }

        // POST: AdicionalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdicionalViewModel adicional)
        {
            try
            {
                _adicionalApp.Atualizar(adicional);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdicionalController/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_adicionalApp.PesquisarPorId(id));
        }

        // POST: AdicionalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(AdicionalViewModel adicional)
        {
            try
            {
                _adicionalApp.Excluir(adicional);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
