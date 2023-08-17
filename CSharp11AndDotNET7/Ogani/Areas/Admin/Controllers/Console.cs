using Microsoft.AspNetCore.Mvc;

namespace Ogani.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Console : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
