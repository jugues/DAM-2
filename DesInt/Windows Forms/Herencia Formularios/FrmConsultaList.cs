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
    public partial class FrmConsultaList : Herencia_Formularios.FrmPadre
    {
        public FrmConsultaList()
        {
            InitializeComponent();
        }

        private void FrmConsultaList_Load(object sender, EventArgs e)
        {
            lvConsultaList.Items.Clear();
            lvConsultaList.View = View.LargeIcon;

            foreach(Cliente c in misClientes)
            {
                string ciudad = c.getCiudad();
                if(!comboCiudad.Items.Contains(ciudad))
                {
                    comboCiudad.Items.Add(c.getCiudad());
                }
            }

            comboVista.Items.Add("Normal");
            comboVista.Items.Add("Detallada");
        }

        private void comboVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboVista.SelectedItem.Equals("Detallada"))
            {
                lvConsultaList.View = View.Details;
            }

            else
            {
                lvConsultaList.View = View.LargeIcon;
            }
        }

        private void comboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Cliente c in misClientes)
            {
                string nombreCliente = c.getNombre();
                string apellidoCliente = c.getApellidos();
                string ciudadCliente = c.getCiudad();
                string correo = c.getEmail();
                string comentarioCliente = c.getComentario();

                if(comboCiudad.SelectedItem.Equals(ciudadCliente))
                {
                    ListViewItem lv = lvConsultaList.Items.Add(nombreCliente, 1);
                    lv.SubItems.Add(apellidoCliente);
                    lv.SubItems.Add(correo);
                    lv.SubItems.Add(comentarioCliente);
                }
            }
        }
    }
}
