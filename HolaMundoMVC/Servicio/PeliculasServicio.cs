using HolaMundoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundoMVC.Servicio
{
    public class PeliculasServicio
    {
        public Pelicula obtenerPelicula()
        {
            return new Pelicula
            {
                Titulo = "Terminator",
                Duracion = 140,
                Pais = "USA",
                Publicacion = new DateTime(2015, 03, 23)
            };
        }
    }
}