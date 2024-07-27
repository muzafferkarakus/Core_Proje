using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Footer
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
