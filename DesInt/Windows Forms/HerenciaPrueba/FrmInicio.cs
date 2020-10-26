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

namespace HerenciaPrueba
{
    public partial class FrmInicio : Form
    {

        //internal static ArrayList list = new ArrayList();
        internal static SortedList <String, Cliente> mySortedList = new SortedList<String, Cliente>();
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta f = new FrmAlta();
            Hide();
            f.Show();
            f.WindowState = FormWindowState.Maximized;
            //f.Text = "¡Hola!";
        }
    }
}
