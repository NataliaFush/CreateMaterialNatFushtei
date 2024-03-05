using Core.Interfaces;
using Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public class ItemRepository : IItemRepository
    {
        protected readonly MyDbContext _myDbContext;
        public ItemRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        private IItem CastToIUser(Models.Item item)
        {
            if (item == null) return null;
            return new Core.Entities.Item
            {
                Id = item.Id,
                Type = item.Type,
                DisplayName = item.DisplayName,
                Department = item.Department,
                HSN = item.HSN,
                BuyingUnit = item.BuyingUnit,
                BuyingUnitPrice = item.SellingUnitPrice,
                SellingUnit = item.SellingUnit,
                SellingUnitPrice = item.SellingUnitPrice,
            };
        }

        public bool CreateItem(IItem item)
        {
            try
            {
                _myDbContext.Items.Add(new Models.Item
                {
                    Id = item.Id,
                    Code=item.Code,
                    Type = item.Type,
                    DisplayName = item.DisplayName,
                    Department = item.Department,
                    HSN = item.HSN,
                    BuyingUnit = item.BuyingUnit,
                    BuyingUnitPrice = item.SellingUnitPrice,
                    SellingUnit = item.SellingUnit,
                    SellingUnitPrice = item.SellingUnitPrice,
                });
                _myDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<IItem> GetAllItems()
        {
            return null;
        }
    }
}
