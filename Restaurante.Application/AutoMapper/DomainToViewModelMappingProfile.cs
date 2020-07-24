using AutoMapper;
using Restaurante.Application.ViewModel;
using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dest => dest.listEndereco, opt => opt.MapFrom(src => src.listEndereco))
                .ForMember(dest => dest.listTelefone, opt => opt.MapFrom(src => src.listTelefone))
                .ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Telefone, TelefoneViewModel>();
            CreateMap<Refeicao, RefeicaoViewModel>();
            CreateMap<Adicional, AdicionalViewModel>();
            CreateMap<Pedido, PedidoViewModel>()
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(src => src.Cliente))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.listAdicional, opt => opt.MapFrom(src => src.listAdicional))
                .ForMember(dest => dest.listRefeicao, opt => opt.MapFrom(src => src.listRefeicao))
                .ReverseMap();
        }
    }
}
