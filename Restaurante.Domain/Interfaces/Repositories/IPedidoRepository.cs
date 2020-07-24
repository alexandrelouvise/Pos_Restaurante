using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        List<Pedido> ListarPedidosPorCliente(Guid idCliente);
    }
}
