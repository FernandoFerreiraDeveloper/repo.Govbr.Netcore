using GovBr.Currency.Service.Dtos;
using GovBr.Currency.Service.Interfaces.Repositories;
using GovBr.Currency.Service.Interfaces.Services;
using GovBr.Currency.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GovBr.Currency.Service.Services
{
    public class ExchangeService : IExchangeService
    {
        private readonly IExchangeRepository _exchangeRepository;
        
        public ExchangeService(IExchangeRepository exchangeRepository) => _exchangeRepository = exchangeRepository;
        
        public async Task<List<ExchangeDto>> GetAllAsync()
        {
            var exchangesModel = await _exchangeRepository.GetAllAsync();

            var exchangesDto = exchangesModel.
                               Select(model => MatToExchangeDto(model)).ToList();

            return exchangesDto;
        }
        
        public async Task<ExchangeDto> GetByIdAsync(string code) 
        {
            var exchangeModel = await _exchangeRepository.GetByIdAsync(code);

            var exchangeDto = MatToExchangeDto(exchangeModel);

            return exchangeDto;
        }

        private static ExchangeDto MatToExchangeDto(Exchange model)
        {
            return new ExchangeDto
            {
                Code = model.Code,
                Country = model.Country,
                Currency = model.Currency,
                Number = model.Number
            };
        }
    }
}
