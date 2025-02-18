using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

public class HomeController : Controller
{
    private readonly IProductRepository _productRepository;

    public HomeController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IActionResult Index()
    {
        var products = _productRepository.GetAllProducts(false);
        return View(products);
    }
}