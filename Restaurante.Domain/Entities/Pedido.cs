using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public int NumeroPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public List<Refeicao> listRefeicao { get; set; }
        public List<Adicional> listAdicional { get; set; }
        public double ValorPedido { get; set; }
        public string Observacao { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
