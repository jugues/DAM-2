using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Multimedia
{
    public partial class FrmAlta : Form
    {
        List<IElementoMultimedia> elementos;
        public FrmAlta()
        {
            InitializeComponent();
        }

        public FrmAlta(List<IElementoMultimedia> elementos)
        {
            InitializeComponent();
            this.elementos = elementos;
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(rbLibro.Checked == true)
            {
                Libro l = new Libro(tb1.Text,
                tb2.Text,
                tb3.Text,
                tb4.Text);
                elementos.Add(l);
                limpiar();
            }

            if(rbRevista.Checked == true)
            {
                Revista r = new Revista(tb1.Text, tb2.Text, tb3.Text, Int32.Parse(tb4.Text));
                elementos.Add(r);
                limpiar();
            }

            if(rbCd.Checked == true)
            {
                Cd c = new Cd(tb1.Text, tb2.Text);
                elementos.Add(c);
                limpiar();
            }
        }

        private void RbRevista_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Fecha";
            label3.Text = "Editorial";
            label4.Text = "Nº";
        }

        private void RbCd_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Discográfica";
            label3.Visible = false;
            label4.Visible = false;
            tb3.Visible = false;
            tb4.Visible = false;
        }

        public void limpiar()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            rbLibro.Checked = false;
            rbRevista.Checked = false;
            rbCd.Checked = false;
        }

        private void RbLibro_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Título";
            label2.Text = "Editorial";
            label3.Text = "ISBN";
            label4.Text = "Resumen";
            label3.Visible = true;
            label4.Visible = true;
            tb3.Visible = true;
            tb4.Visible = true;
        }
    }
}
