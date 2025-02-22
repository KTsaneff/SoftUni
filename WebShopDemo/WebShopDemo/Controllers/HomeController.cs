﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShopDemo.Models;

namespace WebShopDemo.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            //this.HttpContext.Response.Cookies.Append("myCookie", "tempCookie", new CookieOptions()
            //{

            //});

            //this.HttpContext.Session.SetString("name", "Tsaneff");

            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            //string? name = this.HttpContext.Session.GetString("name");

            //if (!string.IsNullOrEmpty(name))
            //{
            //    return Ok(name);
            //}

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}