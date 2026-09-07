using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ServicioCatalogo
    {
        private static List<Libro> libros = new List<Libro>();
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }
        public List<Libro> ObtenerLibros()
        {
            return libros;
        }
    }
}
