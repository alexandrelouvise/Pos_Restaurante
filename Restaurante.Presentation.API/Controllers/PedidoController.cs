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
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoApp _pedidoApp;
        public PedidoController(IPedidoApp pedidoApp)
        {
            _pedidoApp = pedidoApp;
        }
        // GET: api/<PedidoController>
        [HttpGet]
        public IEnumerable<PedidoViewModel> Get()
        {
            return _pedidoApp.ListarTodos();
        }

        // GET api/<PedidoController>/5
        [HttpGet("{id}")]
        public PedidoViewModel Get(Guid id)
        {
            return _pedidoApp.PesquisarPorId(id);
        }

        // POST api/<PedidoController>
        [HttpPost]
        public void Post([FromBody] PedidoViewModel pedido)
        {
            _pedidoApp.Cadastrar(pedido);
        }

        // PUT api/<PedidoController>
        [HttpPut]
        public void Put([FromBody] PedidoViewModel pedido)
        {
            _pedidoApp.Atualizar(pedido);
        }

        // DELETE api/<PedidoController>
        [HttpDelete]
        public void Delete([FromBody] PedidoViewModel pedido)
        {
            _pedidoApp.Excluir(pedido);
        }
    }
}
