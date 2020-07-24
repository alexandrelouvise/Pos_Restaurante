using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Infra.Data.Repositories
{
    public class RefeicaoRepository : Repository<Refeicao>, IRefeicaoRepository
    {
        public RestauranteDbContext _context;
        public RefeicaoRepository(RestauranteDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
