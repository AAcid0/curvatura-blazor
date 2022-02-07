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
            new Pelicula(){Titulo="Peli1",Lanzamiento = new DateTime(2000,03,30)},
            new Pelicula(){Titulo="Peli2",Lanzamiento = new DateTime(2000,10,24)},
            new Pelicula(){Titulo="Peli3",Lanzamiento = new DateTime(2000,12,13)}
        };
        }
    }
}
