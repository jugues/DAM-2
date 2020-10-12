//INCOMPLETA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTrivial
{
    public partial class Form1 : Form
    {

        String opcion;
        int porcentaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //siguiente
        {
            modoGrupos();
        }

        /* 
         Por hacer: eventos, modo grupos de música y modo libros, colores.
         */

        public void modoGrupos()
        {
            Random r = new Random();
            int numRandom = r.Next(0, 4);
            int porcentaje = 100;

            switch(numRandom)
            {
                case 0:
                    txtCancionLibro.Text = "Living on a Prayer";
                    txtOpcion1.Text = "Madonna";
                    txtOpcion2.Text = "The Cranberries";
                    txtOpcion3.Text = "Bon Jovi";
                    txtOpcion4.Text = "The Police";

                    if(txtOpcion3.Capture)
                    {

                    }
                break;

                case 1:
                    txtCancionLibro.Text = "Zombie";
                    txtOpcion1.Text = "Michael Jackson";
                    txtOpcion2.Text = "The Cranberries";
                    txtOpcion3.Text = "AC/DC";
                    txtOpcion4.Text = "U2";
                break;

                case 2:
                    txtCancionLibro.Text = "In the End";
                    txtOpcion1.Text = "Fall Out Boy";
                    txtOpcion2.Text = "blink-182";
                    txtOpcion3.Text = "Marilyn Manson";
                    txtOpcion4.Text = "Linkin Park";
                 break;

                case 3:
                    txtCancionLibro.Text = "Take on Me";
                    txtOpcion1.Text = "Aerosmith";
                    txtOpcion2.Text = "Bruce Springsteen";
                    txtOpcion3.Text = "Led zeppelin";
                    txtOpcion4.Text = "A-ha";
                 break;

                case 4:
                    txtCancionLibro.Text = "By the Way";
                    txtOpcion1.Text = "Green Day";
                    txtOpcion2.Text = "Nirvana";
                    txtOpcion3.Text = "Red Hot Chilli Peppers";
                    txtOpcion4.Text = "The Offspring";
                break;
            }
        }

        public void modoLibros()
        {
            Random ran = new Random();
            int numRan = ran.Next(0, 4);
            int porcentaje = 100;

            switch (numRan)
            {
                case 0:
                    txtCancionLibro.Text = "Añoranzas y Pesares";
                    txtOpcion1.Text = "Miguel de Cervantes";
                    txtOpcion2.Text = "Laura Gallego";
                    txtOpcion3.Text = "Joe Abercrombie";
                    txtOpcion4.Text = "Tad Williams";
                    break;

                case 1:
                    txtCancionLibro.Text = "El último deseo";
                    txtOpcion1.Text = "Margaret Weis";
                    txtOpcion2.Text = "Tracy Hickman";
                    txtOpcion3.Text = "Andrzej Sapkowski";
                    txtOpcion4.Text = "U2";
                    break;

                case 2:
                    txtCancionLibro.Text = "El color de la magia";
                    txtOpcion1.Text = "Andrzej Sapkowski";
                    txtOpcion2.Text = "Terry Pratchett";
                    txtOpcion3.Text = "Javier Negrete";
                    txtOpcion4.Text = "Terry Brooks";
                    break;

                case 3:
                    txtCancionLibro.Text = "La piedra de cristal";
                    txtOpcion1.Text = "R.A. Salvatore";
                    txtOpcion2.Text = "Patrick Rothfuss";
                    txtOpcion3.Text = "Ursula K. Le Guin";
                    txtOpcion4.Text = "Michael Ende";
                    break;

                case 4:
                    txtCancionLibro.Text = "El nombre del viento";
                    txtOpcion1.Text = "Tad Williams";
                    txtOpcion2.Text = "C.S. Lewis";
                    txtOpcion3.Text = "Patrick Rothfuss";
                    txtOpcion4.Text = "Glen Cook";
                    break;
            }
        }

        private void txtOpcion1_Click(object sender, EventArgs e)
        {

        }

        private void txtOpcion2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOpcion3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOpcion4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombrePaísesToolStripMenuItem_Click(object sender, EventArgs e)//modo libros
        {
            lblSuperior.Text = "Libro:";
            lblInferior.Text = "Autor:";
            modoLibros();
        }

        private void nombreGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void múltiplesOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void escribirRespuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOpcion1.ReadOnly = false;
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = false;
            txtOpcion3.Visible = false;
            txtOpcion4.Visible = false;
        }

       private void txtOpcion1_KeyDown(Object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
