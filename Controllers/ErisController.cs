using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LayoutProject.Models;

namespace LayoutProject.Controllers;

public class ErisController : Controller
{
    private readonly ILogger<ErisController> _logger;

    public ErisController(ILogger<ErisController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
