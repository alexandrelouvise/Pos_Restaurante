using Restaurante.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.Interfaces
{
    public interface IPedidoApp : IAppBase<PedidoViewModel>
    {
        List<PedidoViewModel> ListarPedidosPorCliente(Guid idCliente);
    }
}
