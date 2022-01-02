using GovBr.Currency.Repository.Repositories;
using GovBr.Currency.Service.Interfaces.Repositories;
using GovBr.Currency.Service.Interfaces.Services;
using GovBr.Currency.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GovBr.Currency.Api.Extensions
{
    public static class RegisterDependencyManager
    {
        public static void RegisterDependencies(this IServiceCollection services) 
        {
            services.AddScoped<IExchangeService, ExchangeService>();
            services.AddScoped<IExchangeRepository, ExchangeRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
