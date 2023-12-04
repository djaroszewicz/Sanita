using Microsoft.AspNetCore.Mvc;

namespace Sanita.API.Controllers
{
    public class TrainingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
