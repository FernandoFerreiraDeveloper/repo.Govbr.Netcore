using GovBr.Currency.Service.Dtos;
using GovBr.Currency.Service.Models;

namespace GovBr.Currency.Service.Mappers
{
    public static class ExchangeMapper
    {
        public static ExchangeDto MatToExchangeDto(this Exchange model)
        {
            return new ExchangeDto
            {
                Code = model.Code,
                Country = model.Country,
                Currency = model.Currency,
                Number = model.Number
            };
        }

        public static Exchange MatToExchangeModel(this ExchangeDto model)
        {
            return new Exchange
            {
                Code = model.Code,
                Country = model.Country,
                Currency = model.Currency,
                Number = model.Number
            };
        }
    }
}
