using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vote.App.Infrastructure.Filters;
using Vote.Common.ViewModels;
using Vote.Entities;

namespace Vote.App.Areas.Main
{
    [Area("Main")]
    public class HomeController : Controller
    {

        [RedirectLoggedIn]
        public IActionResult Index()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult About()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult NoResult()
        {
            return this.View();
        }
    }
}