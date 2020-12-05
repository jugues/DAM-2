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
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(tbTitulo.Text != null || tbAutor.Text != null || tbEditorial != null || rutaImagen.Equals(""))
            {
                s.Add(new Libro(tbTitulo.Text, tbAutor.Text, tbEditorial.Text, rutaImagen, cbNuevo.Checked));

                limpiar();
            }
        }

        public void limpiar()
        {
            tbTitulo.Text = "";
            tbAutor.Text = "";
            tbEditorial.Text = "";
            rutaImagen = "";
            pctbPortadaAlta.Image = null;
            cbNuevo.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            if (!filedialogFoto.ShowDialog().Equals(DialogResult.Cancel))
            {
                rutaImagen = filedialogFoto.FileName;
                Bitmap imagen = new Bitmap(rutaImagen);
                pctbPortadaAlta.Image = imagen;
            }
        }
    }
}
