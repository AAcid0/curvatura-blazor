using BlazorApp1.Shared.Entidades;
using System.Collections.Generic;

namespace BlazorApp1.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
