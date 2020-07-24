using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Services
{
    public class RefeicaoService : Service<Refeicao>, IRefeicaoService
    {
        private readonly IRefeicaoRepository _refeicaoRepository;
        public RefeicaoService(IRefeicaoRepository refeicaoRepository) : base(refeicaoRepository)
        {
            _refeicaoRepository = refeicaoRepository;
        }
    }
}
