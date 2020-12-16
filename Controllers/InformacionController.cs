using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimerMVCCore.Models;

namespace PrimerMVCCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult VistaPost()
        {
            return View();
        }

        public IActionResult VistaPost(String cajanombre, String cajaedad)
        {
            ViewBag.Nombre = cajanombre;
            ViewBag.Edad = cajaedad;
            return View();
        }

        [HttpPost]
        public IActionResult VistaDatos(String aplicacion, int version)
        {
            ViewBag.Aplicacion = aplicacion;
            ViewBag.Version = version;
            return View();
        }
        public IActionResult Inicio()
        {
            //ViewBag.Nombre = "kdkd";
            //ViewBag.Edad = 18;
            //ViewData["Nombre"] = "usuario";
            //ViewData["Edad"] = 27;
            Persona person = new Persona();
            person.Nombre = "Soy un modelo";
            person.Edad = 99;
            person.Email = "jhdfdhjk@gmail.com";
            return View(person);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
