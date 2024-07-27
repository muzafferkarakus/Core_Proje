using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Script : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
