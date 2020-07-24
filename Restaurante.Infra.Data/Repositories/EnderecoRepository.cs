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
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public RestauranteDbContext _context;
        public EnderecoRepository(RestauranteDbContext context) : base(context)
        {
            _context = context;
        }
        public List<Endereco> PesquisaPorIdCliente(Guid id)
        {
            try
            {
                var result = _context.Set<Cliente>()
                                             .Where(x => x.Id == id)
                                             .IgnoreQueryFilters()
                                             .Include(x => x.listEndereco)
                                             .ToList();
                return result.FirstOrDefault().listEndereco;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
