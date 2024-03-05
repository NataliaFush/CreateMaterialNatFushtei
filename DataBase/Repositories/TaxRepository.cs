using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces.Repositories;

namespace DataBase.Repositories
{
    public class TaxRepository : ITaxRepository
    {
        protected readonly MyDbContext _myDbContext;
        public TaxRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        private ITax? CastToITax(Models.Tax? tax)
        {
            if (tax == null) return null;
            return new Core.Entities.Tax
            {
                Id = tax.Id,
                CGST = tax.CGST,
                SGST = tax.SGST,
                IGST = tax.IGST,
            };
        }

        public bool CreateTax(ITax tax)
        {
            try
            {
                _myDbContext.Taxes.Add(new Models.Tax
                {
                    CGST = tax.CGST,
                    SGST = tax.SGST,
                    IGST = tax.IGST
                });

                _myDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<ITax> GetAllTaxes()
        {
            return null;
        }
    }
}
