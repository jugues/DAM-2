using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia_Formularios
{
    public partial class FrmAlta : Herencia_Formularios.FrmPadre
    {
        public FrmAlta()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbCiudad.Text = "";
            tbEmail.Text = "";
            tbComentario.Text = "";
            cbVip.Checked = false;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            foreach(Cliente c in misClientes)
            {
                listboxClientes.Items.Add(c.getNombre() + " " + c.getApellidos());
            }

            listboxClientes.Sorted = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            string nombre = tbNombre.Text;
            string apellidos = tbApellido.Text;
            string ciudad = tbCiudad.Text;
            string email = tbEmail.Text;
            string comentario = tbComentario.Text;
            bool isVip = cbVip.Checked;

            if (!(tbNombre.Text.Equals("") || tbApellido.Text.Equals("") || tbCiudad.Text.Equals("") || tbEmail.Text.Equals("")))
            {
                misClientes.Add(new Cliente(nombre, apellidos, ciudad, email, comentario, isVip));
                limpiar();
                listboxClientes.Items.Clear();

                foreach(Cliente cliente in misClientes)
                {
                    if(isVip == true)
                    {
                        listboxClientes.Items.Add("★ " + cliente.getNombre() + " " + cliente.getApellidos());
                    }

                    else
                    {
                        listboxClientes.Items.Add(cliente.getNombre() + " " + cliente.getApellidos());
                    }
                }

                listboxClientes.Sorted = true;
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
