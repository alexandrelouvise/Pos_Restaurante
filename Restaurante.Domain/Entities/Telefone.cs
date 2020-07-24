using Restaurante.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Telefone
    {
        public Telefone()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public string  NumeroTelefone { get; set; }
        public TipoTelefone TipoTelefone{ get; set; }
    }
}
