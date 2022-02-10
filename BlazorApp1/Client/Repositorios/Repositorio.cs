using BlazorApp1.Shared.Entidades;
using System;
using System.Collections.Generic;

namespace BlazorApp1.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
        {
            new Pelicula(){Titulo="Peli1",Lanzamiento = new DateTime(2000,03,30), UrlPoster="https://static.vecteezy.com/system/resources/previews/000/688/924/non_2x/color-vintage-poster-on-the-theme-of-rock-and-roll-vector.jpg"},
            new Pelicula(){Titulo="Peli2",Lanzamiento = new DateTime(2000,10,24), UrlPoster="https://static.vecteezy.com/system/resources/previews/000/688/924/non_2x/color-vintage-poster-on-the-theme-of-rock-and-roll-vector.jpg"},
            new Pelicula(){Titulo="Peli3",Lanzamiento = new DateTime(2000,12,13), UrlPoster="https://static.vecteezy.com/system/resources/previews/000/688/924/non_2x/color-vintage-poster-on-the-theme-of-rock-and-roll-vector.jpg"}
        };
        }
    }
}
