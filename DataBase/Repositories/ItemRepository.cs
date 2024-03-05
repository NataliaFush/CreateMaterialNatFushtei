using Core.Interfaces;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
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
                Code = item.Code,
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
                    Code = item.Code,
                    Type = item.Type,
                    DisplayName = item.DisplayName,
                    Department = item.Department,
                    HSN = item.HSN,
                    BuyingUnit = item.BuyingUnit,
                    BuyingUnitPrice = item.SellingUnitPrice,
                    SellingUnit = item.SellingUnit,
                    SellingUnitPrice = item.SellingUnitPrice,
                    Tax = new Models.Tax
                    {
                        CGST = item.Taxes.CGST,
                        SGST = item.Taxes.SGST,
                        IGST = item.Taxes.IGST,
                    }
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
            var items = _myDbContext.Items.Include(x => x.Tax);

            List<IItem> list = new();
            foreach (var item in items)
            {
                if (item != null) list.Add(CastToIUser(item));
            }
            return list;
        }
    }
}
