using AutoMapper;
using Restaurante.Application.Interfaces;
using Restaurante.Application.ViewModel;
using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Restaurante.Application.Service
{
    public class ClienteApp : IClienteApp
    {
        private readonly IClienteService _clienteService;
        private readonly IEnderecoService _enderecoService;
        private readonly IMapper _mapper;

        public ClienteApp(IClienteService clienteService,  IEnderecoService enderecoService, IMapper mapper)
        {
            _clienteService = clienteService;
            _enderecoService = enderecoService;
            _mapper = mapper;
        }
        public void Atualizar(ClienteViewModel cliente)
        {
            var enderecos =_enderecoService.PesquisaPorIdCliente(cliente.Id);
            var enderecosRemovidos = cliente.listEndereco.Where(e => enderecos.All(e2 => e2.Id != e.Id));
            var enderecosNovos = enderecos.Where(e => cliente.listEndereco.All(e2 => e2.Id != e.Id));

            foreach (var item in enderecosRemovidos)
            {
                _enderecoService.Excluir(_mapper.Map<Endereco>(item));
            }

            foreach (var item in enderecosNovos  )
            {
                _enderecoService.Cadastrar(_mapper.Map<Endereco>(item));
            }

            _clienteService.Atualizar(_mapper.Map<Cliente>(cliente));
        }

        public void Cadastrar(ClienteViewModel cliente)
        {
            _clienteService.Cadastrar(_mapper.Map<Cliente>(cliente));
        }

        public void Excluir(ClienteViewModel cliente)
        {
            _clienteService.Excluir(_mapper.Map<Cliente>(cliente));
        }

        public IEnumerable<ClienteViewModel> ListarTodos()
        {
            var cliente = _clienteService.ListarTodos();
            return _mapper.Map<IList<ClienteViewModel>>(cliente);
        }

        public ClienteViewModel PesquisarPorId(Guid id)
        {
            var cliente = _clienteService.PesquisarPorId(id);

            //cliente.listEndereco = _enderecoService.PesquisaPorIdCliente(id);
            return _mapper.Map<ClienteViewModel>(cliente);
        }
    }
}
