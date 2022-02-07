using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Entidades
{
    public class Pelicula
    {
        public Pelicula(string _Titulo, DateTime _Lanzamiento)
        {
            
        }
        public Pelicula() { }

        public string Titulo { get; set; }
        public DateTime Lanzamiento { get; set; }
    }
}
