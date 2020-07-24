using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Interfaces.Services
{
    public interface IEnderecoService : IService<Endereco>
    {
        List<Endereco> PesquisaPorIdCliente(Guid id);
    }
}
