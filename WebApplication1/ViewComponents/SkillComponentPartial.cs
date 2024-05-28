using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents;

public class SkillComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}