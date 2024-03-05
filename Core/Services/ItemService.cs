using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ItemService: IItemService
    {
        protected readonly IItemRepository itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        public bool CreateItem(IItem item)
        {
            Random random = new Random();
            item.Id = Guid.NewGuid();
            item.Code = random.Next(10000000,99999999);
            return itemRepository.CreateItem(item);
        }
    }
}
