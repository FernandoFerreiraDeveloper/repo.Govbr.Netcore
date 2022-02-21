using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using GovBr.Currency.Api.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GovBr.Currency.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration) => Configuration = configuration;        
        
        public void ConfigureServices(IServiceCollection services) => services.Build(Configuration);
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) => app.Build(env);
        
    }
}
