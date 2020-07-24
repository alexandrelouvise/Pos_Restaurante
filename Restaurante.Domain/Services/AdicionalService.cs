using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Services
{
    public class AdicionalService : Service<Adicional>, IAdicionalService
    {
        private readonly IAdicionalRepository _adicionalRepository;
        public AdicionalService(IAdicionalRepository adicionalRepository) : base(adicionalRepository)
        {
            _adicionalRepository = adicionalRepository;
        }
    }
}
