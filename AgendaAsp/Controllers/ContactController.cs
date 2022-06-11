using Microsoft.AspNetCore.Mvc;

namespace AgendaAsp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
