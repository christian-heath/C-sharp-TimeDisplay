using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TimeDisplay.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        [HttpGet("")]
        public IActionResult index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;
            return View();
        }
    }
}