using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}