using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.ViewModel
{
    public class PedidoViewModel
    {
        public PedidoViewModel()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public int NumeroPedido { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public TelefoneViewModel Telefone { get; set; }
        public List<RefeicaoViewModel> listRefeicao { get; set; }
        public List<AdicionalViewModel> listAdicional { get; set; }
        public double ValorPedido { get; set; }
        //public double Desconto { get; set; }
        public string Observacao { get; set; }

        public DateTime DataPedido { get; set; }
    }
}
