using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IItem
    {
        Guid Id { get; set; }
        int? Code { get; set; }
        ItemType? Type { get; set; }
        string? DisplayName { get; set; }
        ItemDepartment? Department { get; set; }
        int? HSN { get; set; }
        SmallestUnit? BuyingUnit { get; set; }
        double? BuyingUnitPrice { get; set; }
        SmallestUnit? SellingUnit { get; set; }
        double? SellingUnitPrice { get; set; }
        int? TaxId { get; set; }
        ITax? Taxes { get; set; }
    }
}
