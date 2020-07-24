using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public List<Telefone> listTelefone { get; set; }
        public List<Endereco> listEndereco { get; set; }
    }
}
