using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Services
{
    public class EnderecoService : Service<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public List<Endereco> PesquisaPorIdCliente(Guid id)
        {
            return _enderecoRepository.PesquisaPorIdCliente(id);
        }
    }
}
