using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GovBr.Currency.Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CurrencyContext _currencyContext;
        
        public RepositoryBase(CurrencyContext currencyContext)
        {
            this._currencyContext = currencyContext;
        }
        public IQueryable<T> FindAll()
        {
            return this._currencyContext.Set<T>().AsNoTracking();
        }
    }
}
