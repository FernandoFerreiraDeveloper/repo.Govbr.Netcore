using Microsoft.OpenApi.Models;
using GovBr.Currency.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GovBr.Currency.Api.Extensions
{
    public static class BuildConfigureServices
    {
        public static void Build(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddControllers();
            services.RegisterDependencies();
            services.AddDbContext<CurrencyContext>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GovBr.Currency.Api", Version = "v1" });
            });
        }
    }
}
