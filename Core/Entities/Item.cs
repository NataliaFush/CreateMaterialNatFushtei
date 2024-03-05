using Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.Entities
{
    public class Item : IItem
    {
        public Guid Id { get; set; }
        public int? Code { get; set; }
        public ItemType? Type { get; set; }
        public string? DisplayName { get; set; }
        public ItemDepartment? Department { get; set; }
        public int? HSN { get; set; }
        public SmallestUnit? BuyingUnit { get; set; }
        public double? BuyingUnitPrice { get; set; }
        public SmallestUnit? SellingUnit { get; set; }
        public double? SellingUnitPrice { get; set; }
        public int? TaxId { get; set; }
        public ITax? Taxes { get; set; }
    }
}
