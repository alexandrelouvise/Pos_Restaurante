using AutoMapper;
using Restaurante.Application.ViewModel;
using Restaurante.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>()
                .ForMember(dest => dest.listEndereco, opt => opt.MapFrom(src => src.listEndereco))
                .ForMember(dest => dest.listTelefone, opt => opt.MapFrom(src => src.listTelefone))
                .ReverseMap();
            CreateMap<TelefoneViewModel, Telefone>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<RefeicaoViewModel, Refeicao>();
            CreateMap<AdicionalViewModel, Adicional>();
            CreateMap<PedidoViewModel, Pedido>()
                .ForMember(dest => dest.Cliente, opt => opt.MapFrom(src => src.Cliente))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => src.Endereco))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.listAdicional, opt => opt.MapFrom(src => src.listAdicional))
                .ForMember(dest => dest.listRefeicao, opt => opt.MapFrom(src => src.listRefeicao))
                .ReverseMap();
        }
    }
}
