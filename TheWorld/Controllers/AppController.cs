﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheWorld.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Form()
		{
			return View();
		}
    }
}
