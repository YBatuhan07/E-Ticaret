using ETicaretData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ContactsController : Controller
    {
        private readonly DataBaseContext _context;

        public ContactsController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Contacts);
        }
    }
}
