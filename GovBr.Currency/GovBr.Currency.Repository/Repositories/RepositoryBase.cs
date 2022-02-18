using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GovBr.Currency.Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CurrencyContext _currencyContext;
        
        public RepositoryBase(CurrencyContext currencyContext)
        {
            this._currencyContext = currencyContext;            
        }
        
        public async Task<List<T>> GetAllAsync()
        {
            return await this._currencyContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {            
            return await _currencyContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> InsertAsync(T entity)
        {
            await _currencyContext.Set<T>().AddAsync(entity);
            
            return Convert.ToBoolean(await _currencyContext.SaveChangesAsync());
        }
    }
}
