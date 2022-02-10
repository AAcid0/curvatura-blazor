using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Debes colocarle un nombre a tu género.")] /*Con este campo se indica que dar un Nombre es obligatorio*/
        public string Nombre { get; set; }
    }
}
