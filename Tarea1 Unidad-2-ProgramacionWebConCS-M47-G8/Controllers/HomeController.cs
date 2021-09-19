using Tarea1_Unidad_2_ProgramacionWebConCS_M47_G8.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tarea1_Unidad_2_ProgramacionWebConCS_M47_G8.Models;

namespace Tarea1_Unidad_2_ProgramacionWebConCS_M47_G8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var clientesServicios = new ClientesServicios();
            var modelo = clientesServicios.obtenerClientes();
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Detalleclientes(int id)
        {
            var clientesServicios = new ClientesServicios();
            var lista = clientesServicios.obtenerClientes();
            var cli = lista.Where(x => x.Codigo == id).SingleOrDefault();
            return View(cli);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
