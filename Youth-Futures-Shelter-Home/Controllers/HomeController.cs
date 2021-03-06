﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Youth_Futures_Shelter_Home.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult _Edit()
        {
            return PartialView();
        }

        public IActionResult Error()
        {
            return View();
        }

        public PartialViewResult _Login()
        {
            return PartialView();
        }
    }
}
