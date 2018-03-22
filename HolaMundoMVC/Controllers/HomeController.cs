using HolaMundoMVC.Models;
using HolaMundoMVC.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            PeliculasServicio servicio = new PeliculasServicio();
            Pelicula model = servicio.obtenerPelicula();

            return View(model);
        }

        public ActionResult Contact2()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
    }
}