using GovBr.Currency.Service.Interfaces.Repositories;

namespace GovBr.Currency.Repository.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private CurrencyContext _context;

        private IExchangeRepository _exchangeRepository;

        public IExchangeRepository Exchange
        {
            get
            {
                if (_exchangeRepository == null)
                {
                    _exchangeRepository = new ExchangeRepository(_context);

                }
                return _exchangeRepository;
            }
        }

    }
}
