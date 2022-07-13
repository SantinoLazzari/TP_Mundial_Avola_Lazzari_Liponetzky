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
    IActionResult VerDetalleEquipo(int IdEquipo)
        {
            ViewBag.VerInfoEquipo = BD.VerInfoEquipo(IdEquipo); 
            return View("VerInfoEquipo");
        }
    IActionResult VerDetalleJugador(int IdJugador)
        {
            ViewBag.VerInfoJugador = BD.VerInfoJugador(IdJugador); 
            return View("VerInfoJugador");
        }
    IActionResult AgregarJugador(int IdEquipo)
        {
            ViewBag.AgregarJugador = IdEquipo; 
            return View("AgregarJugador");
        }
    [HttpPost]IActionResult GuardarJugador(int IdJugador, int IdEquipo, string nombre, DateTime fechaNacimiento, string foto, string equipoActual)
    {
        Jugador jugador = new Jugador(IdJugador, IdEquipo, nombre, fechaNacimiento, foto, equipoActual);
        BD.AgregarJugador(jugador);
        return RedirectToAction("VerDetalleEquipo");
    }
    IActionResult EliminarJugador(int IdJugador)
    {
        BD.EliminarJugador(IdJugador);
        return RedirectToAction("VerDetalleEquipo");
    }

}
