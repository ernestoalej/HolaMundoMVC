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

        public List<Pelicula> obtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Los indestructibles",
                Duracion = 130,
                Pais = "USA",
                Publicacion = new DateTime(2014, 04, 25)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Jhonny English",
                Duracion = 140,
                Pais = "Inglaterra",
                Publicacion = new DateTime(2016, 08, 07)

            };

            var pelicula3 = new Pelicula()
            {
                Titulo = "Fast 8",
                Duracion = 160,
                Pais = "USA",
                Publicacion = new DateTime(2016, 12, 10)

            };

            return new List<Pelicula> { pelicula1, pelicula2, pelicula3};
        }
    }
}