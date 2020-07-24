using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurante.Infra.Data.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public RestauranteDbContext _context;
        public PedidoRepository(RestauranteDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Pedido> ListarPedidosPorCliente(Guid idCliente)
        {
            try
            {
                var result = _context.Set<Pedido>()
                            .Where(x => x.Cliente.Id == idCliente);

                return result.ToList(); ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
