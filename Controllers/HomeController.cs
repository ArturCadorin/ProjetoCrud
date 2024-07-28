using Microsoft.AspNetCore.Mvc;
using ProjetoCrud.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCrud.Models.ViewModels;

namespace ProjetoCrud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Curso C# completo ASP.NET";
            ViewData["Usuario"] = "Artur Cadorin";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Página de contato.";
            
            return View();
        }

        public IActionResult Privacy()
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
