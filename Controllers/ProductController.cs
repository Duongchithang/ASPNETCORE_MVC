using Microsoft.AspNetCore.Mvc;

using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices _productService;

        public ProductController(ProductServices productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            Console.WriteLine(products[0].Name);
            return View(products);
        }
    }
}
