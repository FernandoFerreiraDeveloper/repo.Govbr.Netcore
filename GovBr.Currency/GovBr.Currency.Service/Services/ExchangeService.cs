using GovBr.Currency.Service.Dtos;
using GovBr.Currency.Service.Interfaces.Repositories;
using GovBr.Currency.Service.Interfaces.Services;
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
        public async Task<List<ExchangeDto>> GetAsync()
        {
            var exchangesModel = await _exchangeRepository.GetAsync();

            var exchangesDto = exchangesModel.
                               Select(model => 
                                new ExchangeDto 
                                { 
                                    Code = model.Code, 
                                    Country = model.Country, 
                                    Currency = model.Currency, 
                                    Number = model.Number 
                                }).ToList();

            return exchangesDto;
        }
    }
}
