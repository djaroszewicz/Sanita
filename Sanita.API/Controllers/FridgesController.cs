using Microsoft.AspNetCore.Mvc;

namespace Sanita.API.Controllers
{
    public class FridgesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
