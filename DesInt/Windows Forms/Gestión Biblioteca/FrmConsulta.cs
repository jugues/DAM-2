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
            InitializeComponent();
            this.s = s;
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void rbAutor_CheckedChanged(object sender, EventArgs e)
        {
            listboxTitulo.Items.Clear();
            listboxAutorEditorial.Items.Clear();
            pctbPortadaConsulta.Image = null;

            foreach(Libro libro in s)
            {
                if (!listboxAutorEditorial.Items.Contains(libro.getAutor()))
                {
                    listboxAutorEditorial.Items.Add(libro.getAutor());
                }
            }

            listboxAutorEditorial.Sorted = true;
        }

        private void rbEditorial_CheckedChanged(object sender, EventArgs e)
        {
            listboxTitulo.Items.Clear();
            listboxAutorEditorial.Items.Clear();
            pctbPortadaConsulta.Image = null;

            foreach(Libro l in s)
            {
                if (!listboxAutorEditorial.Items.Contains(l.getEditorial()))
                {
                    listboxAutorEditorial.Items.Add(l.getEditorial());
                }
            }

            listboxAutorEditorial.Sorted = true;
        }

        public void limpiar()
        {
            rbAutor.Checked = false;
            rbEditorial.Checked = false;
            listboxTitulo.Items.Clear();
            listboxAutorEditorial.Items.Clear();
            pctbPortadaConsulta.Image = null;
        }

        private void listboxAutorEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxTitulo.Items.Clear();
            pctbPortadaConsulta.Image = null;
            string seleccion = (string)((ListBox)sender).SelectedItem;

            if(rbAutor.Checked)
            {
                foreach(Libro l in s)
                {
                    if(l.getAutor().Equals(seleccion))
                    {
                        if (!listboxTitulo.Items.Contains(l.getTitulo()))
                        {
                            listboxTitulo.Items.Add(l.getTitulo());
                        }
                    }
                }
            }

            else
            {
                foreach(Libro l in s)
                {
                    if(l.getEditorial().Equals(seleccion))
                    {
                        if(!listboxTitulo.Items.Contains(l.getTitulo()))
                        {
                            listboxTitulo.Items.Add(l.getTitulo());
                        }
                    }
                }
            }

            listboxTitulo.Sorted = true;
        }

        private void listboxTitulo_DoubleClick(object sender, EventArgs e)
        {
            string auxTitulo = (string)((ListBox)sender).SelectedItem;

            foreach(Libro l in s)
            {
                if(l.getTitulo().Equals(auxTitulo))
                {
                    pctbPortadaConsulta.Image = new Bitmap(l.getRutaImagen());
                    break;
                }
            }
        }

        private void listboxTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctbPortadaConsulta.Image = null;
        }
    }
}
