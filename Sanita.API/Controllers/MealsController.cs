﻿using Microsoft.AspNetCore.Mvc;

namespace Sanita.API.Controllers
{
    public class DishesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
