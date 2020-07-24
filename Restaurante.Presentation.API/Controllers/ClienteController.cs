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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteApp _clienteApp;
        public ClienteController(IClienteApp clienteApp)
        {
            _clienteApp = clienteApp;
        }
        // GET: api/<Cliente>
        [HttpGet]
        public IEnumerable<ClienteViewModel> Get()
        {
            return _clienteApp.ListarTodos();
        }

        // GET api/<Cliente>/5
        [HttpGet("{id}")]
        public ClienteViewModel Get(Guid id)
        {
            return _clienteApp.PesquisarPorId(id);
        }

        // POST api/<Cliente>
        [HttpPost]
        public void Post([FromBody] ClienteViewModel cliente)
        {
            _clienteApp.Cadastrar(cliente);
        }

        // PUT api/<Cliente>
        [HttpPut]
        public void Put([FromBody] ClienteViewModel cliente)
        {
            _clienteApp.Atualizar(cliente);
        }

        // DELETE api/<Cliente>
        [HttpDelete]
        public void Delete([FromBody] ClienteViewModel cliente)
        {
            _clienteApp.Excluir(cliente);
        }
    }
}
