using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;
        private readonly Services.Contracts.IProductService _productService;

        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IServiceManager manager, IProductService productService, IWebHostEnvironment webHostEnvironment)
        {
            _manager = manager;
            _productService = productService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var model = _manager.ProductService.GetAllProducts(false);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = GetCategoriesSelectList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] ProductDtoForInsertion productDto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var fileName = Path.GetFileName(file.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                productDto.ImageUrl = String.Concat($"/images/{file.FileName}");
                _manager.ProductService.CreateProduct(productDto);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = GetCategoriesSelectList(); // Ensure categories are repopulated on error
            return View(productDto);
        }
        // public async Task<IActionResult>Create([FromForm] ProductDtoForInsertion productDto ,IFormFile file)
        // {
        //     //file operations
        //     if (ModelState.IsValid){
        //         var fileName = Path.GetFileName(file.FileName);

        //         String path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","images",file.FileName);
        //         using (var stream = new FileStream(path, FileMode.Create))
        //         {
        //            await file.CopyToAsync(stream);
        //         }
        //         productDto.ImageUrl = String.Concat("/images/",fileName);
        //         _manager.ProductService.CreateProduct(productDto);
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View();

        private SelectList GetCategoriesSelectList()
        {
            return new SelectList(_manager.CategoryService.GetAllCategories(false), "CategoryID", "CategoryName", 1);
        }
        [HttpGet("Update/{id}")]

        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            ViewBag.Categories = GetCategoriesSelectList();

            var model = _manager.ProductService.GetOneProductForUpdate(id, false);
            return View(model);
        }
        [HttpPost("Update/{id}")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update([FromForm] ProductDtoForUpdate productDto, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                productDto.ImageUrl = String.Concat($"/images/{file.FileName}");
                _manager.ProductService.UpdateOneProduct(productDto);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.ProductService.DeleteOneProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
}