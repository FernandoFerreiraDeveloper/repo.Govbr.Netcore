using GovBr.Currency.Repository.Configurations;
using GovBr.Currency.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace GovBr.Currency.Repository
{
    public class CurrencyContext : DbContext
    {
        public CurrencyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ExchangeConfiguration());            
        }

        public DbSet<Exchange> Exchanges { get; set; }
    }
}
