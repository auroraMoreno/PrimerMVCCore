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
        //get objetos persona 
        public IActionResult ObjetosPersona()
        {
            //devolver multiples personas
            List<Persona> personas = new List<Persona>();
            for(int i =0; i <=3; i++)
            {
                Persona p = new Persona();
                p.Nombre = "persona " + i;
                p.Edad = i;
                personas.Add(p);
            }
            return View(personas);
        }
        public IActionResult VistaPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaPost(Persona person, String descripcion)
        {
            ViewBag.Descripcion = descripcion;
            //Persona person = new Persona();
            //person.Nombre = cajanombre;
            //person.Email = cajaemail;
            //person.Edad = cajaedad;
            //ViewData["NOMBRE"] = cajanombre;
            //ViewData["EDAD"] = cajaedad;
            //ViewData["EMAIL"] = cajaemail;
        //    ViewBag.Nombre = cajanombre;
        //    ViewBag.Edad = cajaedad;
            return View(person);
        }

    
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
