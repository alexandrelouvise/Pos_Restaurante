using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurante.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public RestauranteDbContext _context;
        public ClienteRepository(RestauranteDbContext context) :base(context)
        {
            _context = context;
        }

        public override IEnumerable<Cliente> ListarTodos()
        {
            try
            {
                var result = _context.Set<Cliente>()
                                             .IgnoreQueryFilters()
                                             .Include(x => x.listEndereco)
                                             .Include(x => x.listTelefone)
                                             .ToList();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public override Cliente PesquisarPorId(Guid id)
        {
            try
            {
                var result = _context.Set<Cliente>()
                             .Include(x => x.listEndereco)
                             .Include(x => x.listTelefone)
                             .SingleOrDefault(x => x.Id == id);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
