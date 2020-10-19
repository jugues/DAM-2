using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Biblioteca
{
    class Libro
    {

        String nom, autor, editorial;
        public Libro (String nombre, String autor, String editorial)
        {
            nom = nombre;
            this.autor = autor;
            this.editorial = editorial;
        }
    }
}
