using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents;

public class NavbarComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}