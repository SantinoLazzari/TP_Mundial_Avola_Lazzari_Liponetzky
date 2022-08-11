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
        ViewBag.Lista=BD.ListarEquipos();
        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult VerDetalleEquipo(int IdEquipo)
        {
            ViewBag.VerInfoEquipo = BD.VerInfoEquipo(IdEquipo); 
            ViewBag.VerInfoJugador = BD.ListarJugador(IdEquipo);
            return View("VerDetalleEquipo");
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult VerDetalleJugador(int IdJugador)
        {
            ViewBag.VerInfoJugador = BD.VerInfoJugador(IdJugador); 
            return View("VerDetalleJugador");
        }

    public IActionResult AgregarJugador(int IdEquipo)
        {
            ViewBag.AgregarJugador = IdEquipo; 
            return View("AgregarJugador");
        }
    public IActionResult AgregarEquipo(int IdEquipo)
        {
            ViewBag.AgregarEquipo = IdEquipo; 
            return View("AgregarEquipo");
        }
    [HttpPost]IActionResult GuardarJugador(int IdEquipo, string nombre, DateTime fechaNacimiento, string foto, string equipoActual)
    {
        Jugador jugador = new Jugador(IdEquipo, nombre, fechaNacimiento, foto, equipoActual);
        BD.AgregarJugador(jugador);
        return RedirectToAction("VerDetalleEquipo","Home",new{IdEquipo=IdEquipo});
    }
    public IActionResult EliminarJugador(int IdJugador)
    {
        BD.EliminarJugador(IdJugador);
        return RedirectToAction("VerDetalleEquipo");
    }

}
