using GovBr.Currency.Service.Interfaces.Repositories;
using GovBr.Currency.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GovBr.Currency.Repository.Repositories
{
    public class ExchangeRepository : RepositoryBase<Exchange>, IExchangeRepository
    {
        public ExchangeRepository(CurrencyContext currencyContext) : base(currencyContext) 
        {
        }        
    }
}
