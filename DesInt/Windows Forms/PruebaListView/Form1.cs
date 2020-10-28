using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PruebaListView
{
    public partial class Principal : Form
    {
        private ListViewGroup libros = new ListViewGroup("Libros", HorizontalAlignment.Left);
        private ListViewGroup pelis = new ListViewGroup("Películas", HorizontalAlignment.Left);
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageList misIconos = new ImageList();
            misIconos.ImageSize = new Size(50, 50);
            String[] iconos = Directory.GetFiles("/");

            try
            {
                foreach(string archivo in iconos)
                {
                    misIconos.Images.Add(Image.FromFile(archivo));
                }
            }

            catch
            {
                MessageBox.Show("Algo salió mal.");
            }

            miListView.SmallImageList = misIconos;

            miListView.Items.Add(new ListViewItem("La cosa", 0, pelis));
            miListView.Items.Add(new ListViewItem("Añoranzas y Pesares", 1, libros));
            miListView.Items.Add(new ListViewItem("El brujer", 3, libros));
            miListView.Items.Add(new ListViewItem("Alien: el octavo pasajero", 4, pelis));
            miListView.Items.Add(new ListViewItem("La naranja mecánica", 5, pelis));
            ListViewItem miElemento = new ListViewItem("Sonrisas y lágrimas", 6, pelis);
            miListView.Items.Add(miElemento);

            miListView.Groups.Add(pelis);
            miListView.Groups.Add(libros);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(rbLibros.Checked == true)
            {
                miListView.Items.Add(new ListViewItem(txtbCaja.Text, libros));
            }

            if(rbPelis.Checked == true)
            {
                miListView.Items.Add(new ListViewItem(txtbCaja.Text, pelis));
            }
        }

        private void miListView_MouseClick(Object sender, MouseEventArgs e)
        {
            lblSeleccionado.Text = miListView.SelectedItems[0].SubItems[0].Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miListView.Items.Clear();
            lblSeleccionado.Text = "Texto seleccionado";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            miListView.SelectedItems[0].SubItems[0].Text = txtbCaja.Text;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            miListView.Items.RemoveAt(miListView.SelectedIndices[0]);
        }
    }
}
