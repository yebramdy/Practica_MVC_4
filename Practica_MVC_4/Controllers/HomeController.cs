﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_MVC_4.Models;


namespace Practica_MVC_4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioVisita()
        {
            return View();
        }

        public ActionResult CargaDatos()
        {
            String nombre = Request.Form["nombre"].ToString();
            String comentarios = Request.Form["comentarios"].ToString();
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();

        }

        public ActionResult ListadoVisitas()
        {

        LibroVisitas Libro = new LibroVisitas();
        string todo = Libro.Leer();     
        ViewData["Libro"] = todo;
        return View();
       

       }
    }
}
