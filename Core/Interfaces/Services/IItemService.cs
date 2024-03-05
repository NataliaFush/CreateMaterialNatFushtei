using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IItemService
    {
        //IItem GetItemById(Guid id);
        bool CreateItem(IItem item);
        //IEnumerable<IItem> GetAllItems();
    }
}
