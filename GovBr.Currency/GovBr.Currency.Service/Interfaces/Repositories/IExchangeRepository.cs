using GovBr.Currency.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GovBr.Currency.Service.Interfaces.Repositories
{
    public interface IExchangeRepository
    {
        Task<List<Exchange>> GetAsync();
    }
}
