using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.Show();
            f.ShowDialog(); //hasta que no acabe este diálogo, no puedo volver a form1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
