using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Multimedia
{
    public class Revista : IElementoMultimedia
    {
        private string titulo, fecha, editorial, textoBuscar;
        bool textoExiste;
        int num;

        public Revista(string titulo, string fecha, string editorial, int num)
        {
            this.titulo = titulo;
            this.fecha = fecha;
            this.editorial = editorial;
            this.num = num;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Num { get => num; set => num = value; }

        bool IElementoMultimedia.buscar(string texto)
        {
            this.textoBuscar = texto;
            return true;
        }

        string IElementoMultimedia.getTitulo()
        {
            return this.titulo;
        }

        void IElementoMultimedia.mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
