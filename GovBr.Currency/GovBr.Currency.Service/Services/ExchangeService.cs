using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using GovBr.Currency.Service.Dtos;
using GovBr.Currency.Service.Mappers;
using GovBr.Currency.Service.Interfaces.Services;
using GovBr.Currency.Service.Interfaces.Repositories;


namespace GovBr.Currency.Service.Services
{
    public class ExchangeService : IExchangeService
    {
        private readonly IExchangeRepository _exchangeRepository;
        
        public ExchangeService(IExchangeRepository exchangeRepository) => _exchangeRepository = exchangeRepository;
        
        public async Task<List<ExchangeDto>> GetAllAsync()
        {
            var exchangesModel = await _exchangeRepository.
                                         GetAllAsync();

            var exchangesDto = exchangesModel.
                                Select(model => model.MatToExchangeDto()).
                                ToList();

            return exchangesDto;
        }
        
        public async Task<ExchangeDto> GetByIdAsync(string code) 
        {
            var exchangeModel = await _exchangeRepository.
                                        GetByIdAsync(code);

            var exchangeDto = exchangeModel.MatToExchangeDto();

            return exchangeDto;
        }

        public async Task<bool> InsertAsync(ExchangeDto exchangeDto)
        {
            var model = exchangeDto.MatToExchangeModel();

            var inserted = await _exchangeRepository.
                                    InsertAsync(model);

            return inserted;
        }       

    }
}
