using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        List<Endereco> PesquisaPorIdCliente(Guid id);
    }
}
