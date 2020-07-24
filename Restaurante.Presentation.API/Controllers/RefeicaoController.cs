using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Application.Interfaces;
using Restaurante.Application.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurante.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefeicaoController : ControllerBase
    {
        private readonly IRefeicaoApp _refeicaoApp;
        public RefeicaoController(IRefeicaoApp refeicaoApp)
        {
            _refeicaoApp = refeicaoApp;
        }
        // GET: api/<RefeicaoController>
        [HttpGet]
        public IEnumerable<RefeicaoViewModel> Get()
        {
            return _refeicaoApp.ListarTodos();
        }

        // GET api/<RefeicaoController>/5
        [HttpGet("{id}")]
        public RefeicaoViewModel Get(Guid id)
        {
            return _refeicaoApp.PesquisarPorId(id);
        }

        // POST api/<RefeicaoController>
        [HttpPost]
        public void Post([FromBody] RefeicaoViewModel refeicao)
        {
            _refeicaoApp.Cadastrar(refeicao);
        }

        // PUT api/<RefeicaoController>
        [HttpPut]
        public void Put([FromBody] RefeicaoViewModel refeicao)
        {
            _refeicaoApp.Atualizar(refeicao);
        }

        // DELETE api/<RefeicaoController>
        [HttpDelete]
        public void Delete([FromBody] RefeicaoViewModel refeicao)
        {
            _refeicaoApp.Excluir(refeicao);
        }
    }
}
