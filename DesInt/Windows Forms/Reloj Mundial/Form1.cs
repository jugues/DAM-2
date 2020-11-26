using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj_Mundial
{
    public partial class Form1 : Form
    {

        SortedList<String, String> paises = new SortedList<string, string>();
        String hora = "";
        ListBox listboxBorrar = new ListBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tbHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void AñadirTsItem_Click(object sender, EventArgs e)
        {

        }
    }
}
