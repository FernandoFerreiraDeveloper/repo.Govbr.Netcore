using GovBr.Currency.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GovBr.Currency.Service.Interfaces.Services
{
    public interface IExchangeService
    {
        List<ExchangeDto> GetAsync();
    }
}
