using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Libro
    {
        [Required(ErrorMessage = "El campo Título es obligatorio.")]
        public string Titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo Autor es obligatorio.")]
        public string Autor { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo Editorial es obligatorio.")]
        public string Editorial { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo Género es obligatorio.")]
        public string Genero { get; set; } = string.Empty;
    }
}
