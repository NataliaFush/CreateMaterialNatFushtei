using Core.Interfaces;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net;

namespace CreateMaterialNatFushtei.Pages
{
    public class AllItemsModel : PageModel
    {
        protected readonly IItemService _itemService;
        //protected readonly IAddressService _addressService;
        public AllItemsModel(IItemService itemService)
        {
            _itemService = itemService;
        }
        public IEnumerable<IItem> Items { get; set; }
        public void OnGet()
        {
            Items = _itemService.GetAllItems();
        }
       
    }
}
