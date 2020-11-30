using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Multimedia
{
    public class Cd : IElementoMultimedia
    {
        string titulo, discografica;

        public Cd(string titulo, string discografica)
        {
            this.titulo = titulo;
            this.discografica = discografica;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Discografica { get => discografica; set => discografica = value; }

        bool IElementoMultimedia.buscar(string texto)
        {
            throw new NotImplementedException();
        }

        string IElementoMultimedia.getTitulo()
        {
            return this.titulo;
        }

        void IElementoMultimedia.mostrar()
        {
            
        }
    }
}
