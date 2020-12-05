using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Formularios
{
    public class Cliente
    {
        private string nombre, apellidos, ciudad, email, comentario;
        private bool esVip;

        public Cliente() { }

        public Cliente(string nombre, string apellidos, string ciudad, string email, string comentario, bool esVip)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ciudad = ciudad;
            this.email = email;
            this.comentario = comentario;
            this.esVip = esVip;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public string getCiudad()
        {
            return ciudad;
        }

        public string getEmail()
        {
            return email;
        }

        public string getComentario()
        {
            return comentario;
        }

        public bool getEsVip()
        {
            return esVip;
        }
        
    }
}
