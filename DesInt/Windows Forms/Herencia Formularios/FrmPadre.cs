using System;
using System.Collections;
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
    public partial class FrmPadre : Form
    {
        internal static ArrayList misClientes = new ArrayList();
        public FrmPadre()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach(Form fo in Application.OpenForms)
            {
                if(fo.GetType().Name.Equals("FrmAlta"))
                {
                    fo.Show();
                    encontrado = true;
                }
            }

            if(!encontrado)
            {
                FrmAlta alta = new FrmAlta();
                alta.Show();
            }

            this.Hide();
        }

        private void consultaListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.GetType().Name.Equals("FrmConsultaList"))
                {
                    f.Show();
                    encontrado = true;
                }
            }

            if(!encontrado)
            {
                FrmConsultaList list = new FrmConsultaList();
                list.Show();
            }

            this.Hide();
        }

        private void consultaTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType().Name.Equals("FrmConsultaTree"))
                {
                    form.Show();
                    encontrado = true;
                }
            }

            if(!encontrado)
            {
                FrmConsultaTree tree = new FrmConsultaTree();
                tree.Show();
            }

            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "¿Quieres salir de la aplicación?";
            string caption = "Cerrando Formulario";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // cerramos el formulario
                Application.Exit();
            }
        }

        private void FrmPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Quieres salir de la aplicación?";
            string caption = "Cerrando Formulario";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            else
            {
                Application.Exit();
            }
        }
    }
}
