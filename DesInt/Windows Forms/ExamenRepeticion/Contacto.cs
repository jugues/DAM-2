using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRepeticion
{
    public class Contacto
    {
        private string tipo, nombre, telefono, ciudad, contacto;
        public Contacto() { }

        public Contacto(string tipo, string nombre, string telf, string ciudad, string contacto)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            telefono = telf;
            this.ciudad = ciudad;
            this.contacto = contacto;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Contact { get => contacto; set => contacto = value; }
    }
}
