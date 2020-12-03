using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_Biblioteca
{
    public class Libro
    {
        private string titulo, autor, editorial, rutaImagen;
        private readonly bool esNuevo;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }
        public bool EsNuevo => esNuevo;

        public Libro(string titulo, string autor, string editorial, string rutaImagen, bool esNuevo)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.rutaImagen = rutaImagen;
            this.esNuevo = esNuevo;
        }
    }
}
