using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;
using StoreApp.Infrastructe.Extensions;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;

        public Cart Cart { get; set; } //IOC
        public string ReturnUrl { get; set; } = "/";
        public CartModel(IServiceManager manager, Cart cartServices)
        {
            _manager = manager;
            Cart = cartServices;
            
        } 
        public void Onget(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

        }
        public IActionResult OnPost(int ProductID, string ReturnUrl)
        {
             Product? product = _manager
                .ProductService
                .GetOneProduct(ProductID,false);
            if (product is not null)
            {
                // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                // HttpContext.Session.SetJson<Cart>("cart", Cart);
            }
            return Page();
        }
        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            Product? product = _manager.ProductService.GetOneProduct(id, false);
            if (product is not null)
            {
                // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Product.ProductID.Equals(id)).Product);
                // HttpContext.Session.SetJson("cart", Cart);
            }
            return Page();
        }
    }
}