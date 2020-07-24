using Autofac;
using Restaurante.Application.Interfaces;
using Restaurante.Application.Service;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using Restaurante.Domain.Services;
using Restaurante.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.CrossCutting.IoC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ClienteApp>().As<IClienteApp>();
            //builder.RegisterType<IEnderecoApp>().As<EnderecoApp>();
            //builder.RegisterType<ITelefoneApp>().As<TelefoneApp>();
            builder.RegisterType<RefeicaoApp>().As<IRefeicaoApp>();
            builder.RegisterType<AdicionalApp>().As<IAdicionalApp>();
            builder.RegisterType<PedidoApp>().As<IPedidoApp>();
            #endregion

            #region IOC Services
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<EnderecoService>().As<IEnderecoService>();
            builder.RegisterType<TelefoneService>().As<ITelefoneService>();
            builder.RegisterType<RefeicaoService>().As<IRefeicaoService>();
            builder.RegisterType<AdicionalService>().As<IAdicionalService>();
            builder.RegisterType<PedidoService>().As<IPedidoService>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<TelefoneRepository>().As<ITelefoneRepositoy>();
            builder.RegisterType<RefeicaoRepository>().As<IRefeicaoRepository>();
            builder.RegisterType<AdicionalRepository>().As<IAdicionalRepository>();
            builder.RegisterType<PedidoRepository>().As<IPedidoRepository>();
            #endregion

            #region IOC Mapper
            //builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            //builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion

            #endregion
        }
    }
}
