﻿using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
