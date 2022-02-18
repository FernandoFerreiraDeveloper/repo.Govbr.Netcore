using GovBr.Currency.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GovBr.Currency.Service.Interfaces.Services
{
    public interface IExchangeService
    {
        Task<List<ExchangeDto>> GetAllAsync();

        Task<ExchangeDto> GetByIdAsync(string code);

        Task<bool> InsertAsync(ExchangeDto exchangeDto);
    }
}
