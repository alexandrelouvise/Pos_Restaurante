using AutoMapper;
using Restaurante.Application.Interfaces;
using Restaurante.Application.ViewModel;
using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.Service
{
    public class AdicionalApp : IAdicionalApp
    {
        private readonly IAdicionalService _adicionalService;
        private readonly IMapper _mapper;
        public AdicionalApp(IAdicionalService adicionalService, IMapper mapper)
        {
            _adicionalService = adicionalService;
            _mapper = mapper;
        }
        public void Atualizar(AdicionalViewModel adicional)
        {
            _adicionalService.Atualizar(_mapper.Map<Adicional>(adicional));
        }

        public void Cadastrar(AdicionalViewModel adicional)
        {
            _adicionalService.Cadastrar(_mapper.Map<Adicional>(adicional));
        }

        public void Excluir(AdicionalViewModel adicional)
        {
            _adicionalService.Excluir(_mapper.Map<Adicional>(adicional));
        }

        public IEnumerable<AdicionalViewModel> ListarTodos()
        {
            var adicional = _adicionalService.ListarTodos();
            return _mapper.Map<List<AdicionalViewModel>>(adicional);
        }

        public AdicionalViewModel PesquisarPorId(Guid Id)
        {
            var adicional = _adicionalService.PesquisarPorId(Id);
            return _mapper.Map<AdicionalViewModel>(adicional);
        }
    }
}
