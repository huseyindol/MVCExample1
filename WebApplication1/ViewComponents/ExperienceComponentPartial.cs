using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents;

public class ExperienceComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}