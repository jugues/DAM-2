using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            tabControl1.SelectTab("tabPage3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            int count = tabControl1.TabPages.Count;
            TabPage t = new TabPage("Página " + (count + 1) );
            tabControl1.TabPages.Add(t);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void btnBorrarTodas_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
        }
    }
}
