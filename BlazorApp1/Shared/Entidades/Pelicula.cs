using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Entidades
{
    public class Pelicula
    {
        public Pelicula(string _Titulo, DateTime _Lanzamiento)
        {
            
        }
        public Pelicula() { }

        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public DateTime? Lanzamiento { get; set; }
        public bool EnCartelera { get; set; }
        public string urlTrailer { get; set; }
        public string Resumen { get; set; }
        public string UrlPoster { get; set; }
        public List<GeneroPelicula> GenerosPeli { get; set; } = new List<GeneroPelicula>();
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }

                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
    }
}
