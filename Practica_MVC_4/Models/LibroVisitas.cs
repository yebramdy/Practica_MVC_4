﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;

namespace Practica_MVC_4.Models
{
    public class LibroVisitas
    {
        public void Grabar(string nombre, string comentarios)

        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Datos/datos.txt", true);
            archivo.WriteLine("Nombre:" + nombre + "<br>Comentarios:" + comentarios + "<hr>");
            archivo.Close();
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Datos/datos.txt");
            string todo = archivo.ReadToEnd();
            return todo;

        }
    }

}