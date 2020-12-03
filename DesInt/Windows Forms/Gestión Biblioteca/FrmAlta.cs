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
    public partial class FrmAlta : Form
    {
        private string rutaImagen; 
        private SortedSet<Libro> s;
        public FrmAlta()
        {
            InitializeComponent();
            rutaImagen = "";
        }

       public FrmAlta(SortedSet<Libro> s)
        {
            InitializeComponent();
            rutaImagen = "";
            this.s = s;
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {

        }
    }
}
