using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Services
{
    public class PeliculasService
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula = new Pelicula()
            {
                Titulo = "XD",
                Duracion = 150,
                Pais = "Usa",
                Publicacion = new DateTime(2012, 12, 11)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "XDdd",
                Duracion = 130,
                Pais = "Usa",
                Publicacion = new DateTime(2015, 03, 02)
            };
            return new List<Pelicula> { pelicula, pelicula2 };
        }
    }
}