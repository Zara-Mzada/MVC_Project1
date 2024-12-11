using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Project1.Models;
using MVC_Project1.Repository;

namespace MVC_Project1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private HomeRepository _homeRepository;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        this._homeRepository = new HomeRepository();
    }
    public IActionResult Index()
    {
        return View(this._homeRepository.GetHomeProducts());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}