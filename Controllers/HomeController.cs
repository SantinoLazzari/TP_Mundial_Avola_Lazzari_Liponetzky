using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Mundial_Avola_Lazzari_Liponetzky.Models;

namespace TP_Mundial_Avola_Lazzari_Liponetzky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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
    public IActionResult VerDetalleEquipo(int IdEquipo)
        {
            ViewBag.VerInfoEquipo = BD.VerInfoEquipo(IdEquipo); 
            return View("VerInfoEquipo");
        }
    public IActionResult VerDetalleJugador(int IdJugador)
        {
            ViewBag.VerInfoJugador = BD.VerInfoJugador(IdJugador); 
            return View("VerInfoJugador");
        }
    public IActionResult AgregarJugador(int IdEquipo)
        {
            ViewBag.AgregarJugador = IdEquipo; 
            return View("AgregarJugador");
        }
    [HttpPost] IActionResult GuardarJugador()
    {
        ViewBag.VerInfoEquipo = BD.VerInfoEquipo(IdEquipo); 
    }

   
}
