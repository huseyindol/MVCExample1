using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents;

public class AboutComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}