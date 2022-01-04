using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovBr.Currency.Service.Interfaces.Repositories
{
    public interface  IRepositoryWrapper
    {
        IExchangeRepository Exchange { get; }
    }
}
