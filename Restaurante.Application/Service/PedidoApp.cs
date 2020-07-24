using AutoMapper;
using Restaurante.Application.Interfaces;
using Restaurante.Application.ViewModel;
using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.Service
{
    public class PedidoApp : IPedidoApp
    {
        private readonly IPedidoService _pedidoService;
        private readonly IMapper _mapper;
        public PedidoApp(IPedidoService pedidoService, IMapper mapper)
        {
            _pedidoService = pedidoService;
            _mapper = mapper;
        }
        public void Atualizar(PedidoViewModel pedido)
        {
            _pedidoService.Atualizar(_mapper.Map<Pedido>(pedido));
        }

        public void Cadastrar(PedidoViewModel pedido)
        {
            _pedidoService.Cadastrar(_mapper.Map<Pedido>(pedido));
        }

        public void Excluir(PedidoViewModel pedido)
        {
            _pedidoService.Excluir(_mapper.Map<Pedido>(pedido));
        }

        public List<PedidoViewModel> ListarPedidosPorCliente(Guid idCliente)
        {
            var pedido = _pedidoService.ListarPedidosPorCliente(idCliente);
            return _mapper.Map<List<PedidoViewModel>>(pedido);
        }

        public IEnumerable<PedidoViewModel> ListarTodos()
        {
            var pedido = _pedidoService.ListarTodos();
            return _mapper.Map<List<PedidoViewModel>>(pedido);
        }

        public PedidoViewModel PesquisarPorId(Guid Id)
        {
            var pedido = _pedidoService.PesquisarPorId(Id);
            return _mapper.Map<PedidoViewModel>(pedido);
        }
    }
}
