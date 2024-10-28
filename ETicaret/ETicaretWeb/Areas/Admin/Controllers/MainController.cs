using Microsoft.AspNetCore.Mvc;

namespace ETicaretWeb.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
