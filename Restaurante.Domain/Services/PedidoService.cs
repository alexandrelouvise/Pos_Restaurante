using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Services
{
    public class PedidoService : Service<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository) : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public List<Pedido> ListarPedidosPorCliente(Guid idCliente)
        {
            return _pedidoRepository.ListarPedidosPorCliente(idCliente);
        }
    }
}
