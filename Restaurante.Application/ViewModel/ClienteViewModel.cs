using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.ViewModel
{
    public class ClienteViewModel
    {

        public ClienteViewModel()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public List<TelefoneViewModel> listTelefone { get; set; }
        public List<EnderecoViewModel> listEndereco { get; set; }

    }
}
