using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Adicional
    {
        public Adicional()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        //public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
