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
    public partial class FrmConsulta : Form
    {
        private SortedSet<Libro> s;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        public FrmConsulta(SortedSet<Libro> s)
        {
            this.s = s;
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
