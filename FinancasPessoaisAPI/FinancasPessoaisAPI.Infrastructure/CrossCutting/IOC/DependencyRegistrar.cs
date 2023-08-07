using FinancasPessoaisAPI.Application.Interfaces;
using FinancasPessoaisAPI.Application.Services;
using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;
using FinancasPessoaisAPI.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FinancasPessoaisAPI.Infrastructure.CrossCutting.IOC
{
    public static class DependencyRegistrar
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            // Services
            services.AddScoped<IManterDespesaService, ManterDespesaService>();
            services.AddScoped<IManterReceitaService, ManterReceitaService>();

            // Repositories
            services.AddScoped<IDespesaRepository, DespesaRepository>();
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
        }
    }
}
