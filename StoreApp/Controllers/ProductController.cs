using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repositories.Contracts;
using Services.Contracts;
using Entities.Models;


namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        
         public IActionResult Get([FromRoute(Name ="id")] int id)
         {
             var model = _serviceManager.ProductService.GetOneProduct(id, false);
             return View(model);
         }

        public IActionResult Index()
        {
            var model = _serviceManager.ProductService.GetAllProducts( false).ToList();
            return View(model);
       }
    }
}