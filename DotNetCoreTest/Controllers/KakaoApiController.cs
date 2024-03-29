﻿using DotNetCoreTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreTest.Controllers
{
    public class KakaoApiController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public KakaoApiController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult KakaoMap()
        {
            return View();
        }

        public IActionResult KakaoMap2()
        {
            return View();
        }

        public IActionResult KakaoMap3()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
