using GovBr.Currency.Service.Interfaces.Repositories;
using GovBr.Currency.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GovBr.Currency.Repository.Repositories
{
    public class ExchangeRepository : IExchangeRepository
    {
        private readonly CurrencyContext _currencyContext;
        
        public ExchangeRepository(CurrencyContext currencyContext) => _currencyContext = currencyContext;

        public async Task<List<Exchange>> GetAsync()
        {
            var exchanges = await _currencyContext.Exchanges.ToListAsync();

            return exchanges;
        }
    }
}
