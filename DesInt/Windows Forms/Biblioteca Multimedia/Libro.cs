using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Multimedia
{
    public class Libro : IElementoMultimedia
    {
        private string titulo, editorial, isbn, resumen;

        public Libro(string titulo, string editorial, string isbn, string resumen)
        {
            this.titulo = titulo;
            this.editorial = editorial;
            this.isbn = isbn;
            this.resumen = resumen;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Resumen { get => resumen; set => resumen = value; }

        bool IElementoMultimedia.buscar(string texto)
        {
            throw new NotImplementedException();
        }

        string IElementoMultimedia.getTitulo()
        {
            throw new NotImplementedException();
        }

        void IElementoMultimedia.mostrar()
        {
            throw new NotImplementedException();
        }
    }
    
}
