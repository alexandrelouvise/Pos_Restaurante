using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Infra.Data.Repositories
{
    public class TelefoneRepository: Repository<Telefone>, ITelefoneRepositoy
    {
        public RestauranteDbContext _context;
        public TelefoneRepository(RestauranteDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
