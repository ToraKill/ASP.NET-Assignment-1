using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    /// 
    /// 
    /// 
public ActionResult Index()
            {
                return View("C:\Users\Len\Desktop\Sem 4\ASP.NET\Assignment 1\Assignment1\Controllers\brief.cs",db.Users.ToList());
            }
}
