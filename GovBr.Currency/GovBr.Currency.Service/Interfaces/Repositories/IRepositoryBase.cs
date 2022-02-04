using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GovBr.Currency.Repository.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
    }
}
