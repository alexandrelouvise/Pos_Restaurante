using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Interfaces.Services
{
    public interface IPedidoService : IService<Pedido>
    {
        List<Pedido> ListarPedidosPorCliente(Guid idCliente);
    }
}
