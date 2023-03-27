using Microsoft.AspNetCore.Mvc;
using SellerProduct.IServices;
using SellerProduct.Models;
using SellerProduct.Services;
using System.Diagnostics;

namespace SellerProduct.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService _productService; // Interface

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _productService = new ProductService(); // Dependency Injection
    }

    public IActionResult Index()
    {
        var products = _productService.GetAllProducts();
        return View(products.Where(p => p.AvailableQuantity > 5 && p.Status > 1)); // trả về cùng tên với action
    }
    public IActionResult Details(Guid id)
    {
        var products = _productService.GetProductById(id);
        return View(products); //
    }

    public IActionResult ShowListProduct()
    {
        var products = _productService.GetAllProducts();
        return View(products); // Truyền tới View 1 object model
    }

    public IActionResult Create() // Mở form
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product product)// Thực hiện việc thêm
    {
        _productService.CreateProduct(product);
        return RedirectToAction("ShowListProduct");
    }

    [HttpGet]
    public IActionResult Update(Guid id) // Mở form, truyền luôn sang form
    {
        var product = _productService.GetProductById(id);

        return View(product);
    }

    public IActionResult Update(Product p) // Mở form
    {
        //    var product = productServices.UpdateProduct(p);

        if (p.Price < 1)
        {
            ModelState.AddModelError("", "giá lớn hơn 1");
            return View();
        }
        if (p.AvailableQuantity < 1)
        {
            ModelState.AddModelError("", "số lượng lớn" +
                " hơn 1");
            return View();
        }
        if (p.Status < 1)
        {
            ModelState.AddModelError("", "trạng thái phải lớn hơn 1");
            return View();
        }
        if (_productService.UpdateProduct(p))
        {

            return RedirectToAction("ShowListProduct");
        }
        else return BadRequest();
    }
    public IActionResult Delete(Guid id)
    {
        _productService.DeleteProduct(id);
        return RedirectToAction("ShowListProduct");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}