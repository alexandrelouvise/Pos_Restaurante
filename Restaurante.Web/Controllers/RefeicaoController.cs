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
    public class RefeicaoController : Controller
    {
        public readonly IRefeicaoApp _refeicaoApp;

        public RefeicaoController(IRefeicaoApp refeicaoApp)
        {
            _refeicaoApp = refeicaoApp;
        }
        // GET: RefeicaoController
        public ActionResult Index()
        {
            return View(_refeicaoApp.ListarTodos());
        }

        // GET: RefeicaoController/Details/5
        public ActionResult Details(Guid Id)
        {
            return View(_refeicaoApp.PesquisarPorId(Id));
        }

        // GET: RefeicaoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RefeicaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RefeicaoViewModel refeicao)
        {
            try
            {
                _refeicaoApp.Cadastrar(refeicao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RefeicaoController/Edit/5
        public ActionResult Edit(Guid Id)
        {
            return View(_refeicaoApp.PesquisarPorId(Id));
        }

        // POST: RefeicaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RefeicaoViewModel refeicao)
        {
            try
            {
                _refeicaoApp.Atualizar(refeicao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RefeicaoController/Delete/5
        public ActionResult Delete(Guid Id)
        {
            return View(_refeicaoApp.PesquisarPorId(Id));
        }

        // POST: RefeicaoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(RefeicaoViewModel refeicao)
        {
            try
            {
                _refeicaoApp.Excluir(refeicao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
