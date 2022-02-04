using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GovBr.Currency.Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CurrencyContext _currencyContext;        
        internal DbSet<T> dbSet;

        public RepositoryBase(CurrencyContext currencyContext)
        {
            this._currencyContext = currencyContext;
            this.dbSet = _currencyContext.Set<T>();
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await this._currencyContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }
    }
}
