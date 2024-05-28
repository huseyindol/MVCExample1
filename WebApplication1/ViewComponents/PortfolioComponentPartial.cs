using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents;

public class PortfolioComponentPartial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}