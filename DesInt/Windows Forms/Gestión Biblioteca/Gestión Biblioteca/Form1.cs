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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora actual: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void AltaCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            IsMdiContainer = true;
            f.MdiParent = this;
            f.show();
        }

        private void ConsultaCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fe = new Form3();
            fe.MdiParent = this;
            fe.show();
        }
    }
}
