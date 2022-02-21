using GovBr.Currency.Service.Dtos;
using GovBr.Currency.Service.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace GovBr.Currency.Api.Controllers
{
    [ApiController]
    [Route("api/v1/exchanges")]
    [OpenApiTag("Exchanges", Description = "All exchanges in database")]
    public class ExchangeController : Controller
    {        
        private readonly IExchangeService _exchangeService;
        
        public ExchangeController(IExchangeService exchangeService) => this._exchangeService = exchangeService;        
        
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(List<ExchangeDto>), Description = "The exchanges")]
        public async Task<IActionResult> GetCultures()
        {
            return Ok(await _exchangeService.GetAllAsync());
        }

        [HttpGet("{country}")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(ExchangeDto), Description = "The exchange by country")]
        public async Task<IActionResult> Get(string country)
        {
            return Ok(await _exchangeService.GetByIdAsync(country));
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(bool), Description = "Insert a new Exchange")]
        public async Task<IActionResult> Post(ExchangeDto exchangeDto)
        {
            return Ok(await _exchangeService.InsertAsync(exchangeDto));
        }
    }
}
