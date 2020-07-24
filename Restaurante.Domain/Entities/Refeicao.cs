using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Refeicao
    {
        public Refeicao()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        //public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
