using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurante.Domain.Entities;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using Restaurante.Domain.Services;
using Restaurante.Infra.Data.Repositories;
using System;

namespace Restaurante.CrossCutting.IoC
{
    public class Injector
    {

        public static void RegisterContext(IServiceCollection services, IConfiguration configuration)
        {

        }

        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IService<Cliente>, Service<Cliente>>();
            services.AddScoped<IService<Endereco>, Service<Endereco>>();
            services.AddScoped<IService<Telefone>, Service<Telefone>>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<ITelefoneService, TelefoneService>();
        }

        public static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IRepository<Cliente>, Repository<Cliente>>();
            services.AddScoped<IRepository<Endereco>, Repository<Endereco>>();
            services.AddScoped<IRepository<Telefone>, Repository<Telefone>>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepositoy, TelefoneRepository>();
        }

        public static void RegisterOptions(IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<Settings>(options =>
            //{ 
            //}

            //services.Con
            //    services.Configure<Settings>(options =>
            //    {
            //        //options.PlanoAplicacaoConnectionString = configuration.GetSection("PlanoAplicacaoSettings:ConnectionStrings:PlanoAplicacao").Value;
            //    }
        }

    }
}
