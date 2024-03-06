using CreateMaterialNatFushtei.PagesModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Core.Interfaces.Services;
using Core.Enums;
using Core.Entities;

namespace CreateMaterialNatFushtei.Pages
{
    public class CreateItem : PageModel
    {
        protected readonly IItemService _itemService;
        public ResultModel Response { get; set; }
        public CreateItem(IItemService itemService)
        {
            _itemService = itemService;
        }
        public IEnumerable<ItemModel> Items { get; set; }
        [BindProperty(SupportsGet = true)]
        public ItemModel Input { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            if (Input != null)
            {
                var item = new Item()
                {
                    Type = Input.Type,
                    DisplayName = Input.DisplayName,
                    Department = Input.Department,
                    HSN = Input.HSN,
                    BuyingUnit = Input.BuyingUnit,
                    BuyingUnitPrice = Input.BuyingUnitPrice,
                    SellingUnit = Input.SellingUnit,
                    SellingUnitPrice = Input.SellingUnitPrice,
                    Taxes = new Tax() { 
                        CGST = Input.CGST,  
                        SGST = Input.SGST,
                        IGST = Input.IGST,
                    }
                };
                if (_itemService.CreateItem(item))
                {
                    Response = new ResultModel() { ResultType = ResultType.Success, Message = $"Item {Input.DisplayName} was created" };
                }
                else
                {
                    Response = new ResultModel() { ResultType = ResultType.Error, Message = $"Item {Input.DisplayName} was not created" };
                }
            }
            else
            {
                Response = new ResultModel() { ResultType = ResultType.Error, Message = $"Item {Input.DisplayName} was not created" };
            }
        }
    }
}

