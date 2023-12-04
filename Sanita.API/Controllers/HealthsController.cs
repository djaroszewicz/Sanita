using Microsoft.AspNetCore.Mvc;

namespace Sanita.API.Controllers
{
    public class HealthsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
