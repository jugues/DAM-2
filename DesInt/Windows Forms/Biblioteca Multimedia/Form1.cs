using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Multimedia
{
    public partial class FrmPrincipal : Form 
    {

        List<IElementoMultimedia> elementos;
        FrmAlta alta;
        FrmConsulta consulta;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void AltaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (consulta != null)
            {
                consulta.Close();
                consulta = null;
            }

            if (alta == null)
            {
                alta = new FrmAlta();
                alta.MdiParent = this;
                alta.Dock = DockStyle.Fill;
                alta.Show();
            }

        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(alta != null)
            {
                alta.Close();
                alta = null;
            }
            if(consulta == null)
            {
                consulta = new FrmConsulta();
                consulta.MdiParent = this;
                consulta.Dock = DockStyle.Fill;
                consulta.Show();
            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            const string message = "¿Quieres salir de la aplicación?";
            const string caption = "Aviso";

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
