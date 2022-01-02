using System.Linq;

namespace GovBr.Currency.Repository.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();        
    }
}
