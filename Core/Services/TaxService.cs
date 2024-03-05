using Core.Entities;
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
    public class TaxService : ITaxService
    {
        protected readonly ITaxRepository taxRepository;
        public TaxService(ITaxRepository taxRepository)
        {
            this.taxRepository = taxRepository;
        }
        
    }
}
