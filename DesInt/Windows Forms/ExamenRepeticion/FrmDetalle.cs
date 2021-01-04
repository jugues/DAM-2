using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRepeticion
{
    public partial class FrmDetalle : Form
    {
        public List<Contacto> contactosEditar = new List<Contacto>();
        Contacto editando;
        public FrmDetalle()
        {
            InitializeComponent();
        }

        public FrmDetalle(List<Contacto> l, Contacto aEditar)
        {
            contactosEditar = l;
            editando = aEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbTelefono.Text = "";
            tbPersonaContacto.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
