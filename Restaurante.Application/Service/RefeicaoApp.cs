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
    public class RefeicaoApp : IRefeicaoApp
    {
        private readonly IRefeicaoService _refeicaoService;
        private readonly IMapper _mapper;

        public RefeicaoApp(IRefeicaoService refeicaoService, IMapper mapper)
        {
            _refeicaoService = refeicaoService;
            _mapper = mapper;
        }
        public void Atualizar(RefeicaoViewModel refeicao)
        {
            _refeicaoService.Atualizar(_mapper.Map<Refeicao>(refeicao));
        }

        public void Cadastrar(RefeicaoViewModel refeicao)
        {
            _refeicaoService.Cadastrar(_mapper.Map<Refeicao>(refeicao));
        }

        public void Excluir(RefeicaoViewModel refeicao)
        {
            _refeicaoService.Excluir(_mapper.Map<Refeicao>(refeicao));
        }

        public IEnumerable<RefeicaoViewModel> ListarTodos()
        {
            var refeicao = _refeicaoService.ListarTodos();
            return _mapper.Map<List<RefeicaoViewModel>>(refeicao);
        }

        public RefeicaoViewModel PesquisarPorId(Guid Id)
        {
            var refeicao = _refeicaoService.PesquisarPorId(Id);
            return _mapper.Map<RefeicaoViewModel>(refeicao);
        }
    }
}
