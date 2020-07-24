using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Restaurante.Domain.Services
{
    public class TelefoneService : Service<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepositoy _telefoneRepositoy;
        public TelefoneService(ITelefoneRepositoy telefoneRepositoy) : base(telefoneRepositoy)
        {
            _telefoneRepositoy = telefoneRepositoy;
        }
    }
}
