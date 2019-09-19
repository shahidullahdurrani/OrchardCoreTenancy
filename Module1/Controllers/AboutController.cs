using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.Controllers
{
    public class AboutController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
