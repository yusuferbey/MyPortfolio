using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _NavbarComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
