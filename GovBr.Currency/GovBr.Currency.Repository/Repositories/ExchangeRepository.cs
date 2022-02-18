using GovBr.Currency.Service.Models;
using GovBr.Currency.Service.Interfaces.Repositories;

namespace GovBr.Currency.Repository.Repositories
{
    public class ExchangeRepository : RepositoryBase<Exchange>, IExchangeRepository
    {
        public ExchangeRepository(CurrencyContext currencyContext) : base(currencyContext) 
        {
        }        
    }
}
