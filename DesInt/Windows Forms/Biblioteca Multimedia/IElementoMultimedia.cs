using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Multimedia
{
    public interface IElementoMultimedia
    {
        Boolean buscar(string texto);
        void mostrar();
        string getTitulo();
    }
}
