using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class PeliculasController : Controller
    {
        private Pelicula pelicula = new Pelicula();

        // GET: Peliculas
        public ActionResult Index()
        {
            ViewBag.peliculas = pelicula.ObtenerDatos();
            return View();

        }     
    }
}
