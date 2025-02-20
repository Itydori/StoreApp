using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;

        public CartModel(IServiceManager manager)
        {
            _manager = manager;
        }

        public Cart Cart { get; set; } //IOC
        public string ReturnUrl { get; set; } ="/";
        public void Onget(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(int ProductID,string ReturnUrl)
        {
            Product? product = _manager.ProductService.GetOneProduct(ProductID,false);
            if (product is not null)
            {
                Cart.AddItem(product, 1);
            }
            return Page();
        }
        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl=>cl.Product.ProductID.Equals(id)).Product);
            return Page();
        }
    }
}