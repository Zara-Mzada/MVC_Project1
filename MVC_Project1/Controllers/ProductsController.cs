using Microsoft.AspNetCore.Mvc;
using MVC_Project1.Repository;

namespace MVC_Project1.Controllers;

public class ProductsController : Controller
{
    private ProductsRepository productsRepository;
    public ProductsController()
    {
        this.productsRepository = new ProductsRepository();
    }
    public IActionResult Index(int id)
    {
        return View(this.productsRepository.GetByCategory(id));
    }
}