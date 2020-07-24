using Restaurante.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string  Complemento { get; set; }
        public string  Bairro { get; set; }
        public string Cidade { get; set; }
        //public TipoEndereco TipoEndereco{ get; set; }
    }
}
