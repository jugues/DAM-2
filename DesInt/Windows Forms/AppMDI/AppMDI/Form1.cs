using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); //ordenar ventanas horizontalmente
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            foreach(Form element in Application.OpenForms)
            {
                MessageBox.Show(element.Text, "Probando colecciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //otra forma de recorrer los hijos 

            foreach (Form element in MdiChildren) //no sacamos el padre
            {
                MessageBox.Show(element.Text, "Probando colecciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /* foreach (Form element in MdiChildren) 
            {
                MessageBox.Show(element.GetType().Name, "Probando colecciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } */
        }
    }
}
