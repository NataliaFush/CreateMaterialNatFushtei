using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface ITaxRepository
    {
        bool CreateTax(ITax tax);
        IEnumerable<ITax> GetAllTaxes();
    }
}
