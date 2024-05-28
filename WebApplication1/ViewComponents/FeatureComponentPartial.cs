using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents;

public class FeatureComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}