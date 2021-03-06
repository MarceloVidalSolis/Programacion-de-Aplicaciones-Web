using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PRACTICA12.Models;

namespace PRACTICA12.Controllers
{
    public class AreaController : Controller
    {
        private readonly ILogger<AreaController> _logger;

        public AreaController(ILogger<AreaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string numero1, string numero2, string tipo)
        {
            int a = Convert.ToInt32(numero1);
            int b = Convert.ToInt32(numero2);
            int c = 0;
            if(tipo=="Triangulo")
            {
                c=(a*b)/2;
                ViewBag.Resultado = c;
            }
            else if(tipo=="Rectangulo") {
                c=(a*b);
                ViewBag.Resultado = c;
            }
            else{
                ViewBag.Resultado = c;
            }
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
