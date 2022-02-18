using System.Collections.Generic;
using System.Threading.Tasks;

namespace GovBr.Currency.Repository.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> GetAllAsync();
        
        Task<T> GetByIdAsync(object id);

        Task<bool> InsertAsync(T entity);
    }
}
