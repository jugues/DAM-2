using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Biblioteca
{
    public partial class FrmPadre : Form
    {
        FrmAlta alta;
        FrmConsulta consulta;
        private SortedSet<Libro> misLibros;
        public FrmPadre()
        {
            InitializeComponent();
            misLibros = new SortedSet<Libro>();
            timer.Enabled = true;
            alta = null;
            consulta = null;
        }

        private void FrmPadre_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora actual: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(consulta != null)
            {
                consulta.Close();
                consulta = null;
            }

            if(alta == null)
            {
                alta = new FrmAlta(misLibros);
                alta.MdiParent = this;
                alta.Show();
                alta.Dock = DockStyle.Fill;
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(alta != null)
            {
                alta.Close();
                alta = null;
            }

            if(consulta == null)
            {
                consulta = new FrmConsulta(misLibros);
                consulta.MdiParent = this;
                consulta.Show();
                consulta.Dock = DockStyle.Fill;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
