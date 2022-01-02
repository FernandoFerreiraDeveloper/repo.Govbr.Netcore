using GovBr.Currency.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GovBr.Currency.Repository.Configurations
{
    public class ExchangeConfiguration : IEntityTypeConfiguration<Exchange>
    {
        public void Configure(EntityTypeBuilder<Exchange> builder)
        {
            builder.HasKey(x => x.Country);            
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.Currency).IsRequired();
            builder.Property(x => x.Number).IsRequired();

            builder.HasData(
                new Exchange
                {
                    Country = "ÍNDIA",
                    Currency = "Rupia indiana",
                    Code = "INR",
                    Number = 356
                },
            new Exchange
            {
                Country = "ÁUSTRIA",
                Currency = "Euro",
                Code = "EUR",
                Number = 978
            }
            );


        }
    }
}
