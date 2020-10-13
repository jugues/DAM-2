//el modo de escritura manual de respuestas y el botón de nueva partida no funcionan como deberían, igual que el textbox del porcentaje de aciertos

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
        String correcta;
        public Form1()
        {
            InitializeComponent();
            modoGrupos();
        }

        private void button1_Click(object sender, EventArgs e) //siguiente
        {
            if (nombreGruposToolStripMenuItem.Checked)
            {
                modoGrupos();
            }

            else
            {
                modoLibros();
            }
        }

        public void limpiarCajas()
        {
            txtOpcion1.BackColor = SystemColors.Control;
            txtOpcion2.BackColor = SystemColors.Control;
            txtOpcion3.BackColor = SystemColors.Control;
            txtOpcion4.BackColor = SystemColors.Control;
        }

        public void modoGrupos()
        {
            Random r = new Random();
            int numRandom = r.Next(0, 4);
            int porcentaje = 0;
            limpiarCajas();

            switch (numRandom)
            {
                case 0:
                    txtCancionLibro.Text = "Living on a Prayer";
                    txtOpcion1.Text = "Madonna";
                    txtOpcion2.Text = "The Cranberries";
                    txtOpcion3.Text = "Bon Jovi";
                    txtOpcion4.Text = "The Police";

                    correcta = "Bon Jovi";
                break;

                case 1:
                    txtCancionLibro.Text = "Zombie";
                    txtOpcion1.Text = "Michael Jackson";
                    txtOpcion2.Text = "The Cranberries";
                    txtOpcion3.Text = "AC/DC";
                    txtOpcion4.Text = "U2";

                    correcta = "The Cranberries";
                break;

                case 2:
                    txtCancionLibro.Text = "In the End";
                    txtOpcion1.Text = "Fall Out Boy";
                    txtOpcion2.Text = "blink-182";
                    txtOpcion3.Text = "Marilyn Manson";
                    txtOpcion4.Text = "Linkin Park";

                    correcta = "Linkin Park";
                 break;

                case 3:
                    txtCancionLibro.Text = "Take on Me";
                    txtOpcion1.Text = "Aerosmith";
                    txtOpcion2.Text = "Bruce Springsteen";
                    txtOpcion3.Text = "Led zeppelin";
                    txtOpcion4.Text = "A-ha";

                    correcta = "A-ha";
                 break;

                case 4:
                    txtCancionLibro.Text = "By the Way";
                    txtOpcion1.Text = "Green Day";
                    txtOpcion2.Text = "Nirvana";
                    txtOpcion3.Text = "Red Hot Chilli Peppers";
                    txtOpcion4.Text = "The Offspring";

                    correcta = "Red Hot Chilli Peppers";
                break;
            }
        }

        public void modoLibros()
        {
            Random ran = new Random();
            int numRan = ran.Next(0, 4);
            int porcentaje = 100;
            limpiarCajas();

            switch (numRan)
            {
                
                case 0:
                    txtCancionLibro.Text = "Añoranzas y Pesares";
                    txtOpcion1.Text = "Miguel de Cervantes";
                    txtOpcion2.Text = "Laura Gallego";
                    txtOpcion3.Text = "Joe Abercrombie";
                    txtOpcion4.Text = "Tad Williams";

                    correcta = "Tad Williams"; 
                    break;

                case 1:
                    txtCancionLibro.Text = "El último deseo";
                    txtOpcion1.Text = "Margaret Weis";
                    txtOpcion2.Text = "Tracy Hickman";
                    txtOpcion3.Text = "Andrzej Sapkowski";
                    txtOpcion4.Text = "Miguel de Cervantes";

                    correcta = "Andrzej Sapkowski";
                    break;

                case 2:
                    txtCancionLibro.Text = "El color de la magia";
                    txtOpcion1.Text = "Andrzej Sapkowski";
                    txtOpcion2.Text = "Terry Pratchett";
                    txtOpcion3.Text = "Javier Negrete";
                    txtOpcion4.Text = "Terry Brooks";

                    correcta = "Terry Pratchett";
                    break;

                case 3:
                    txtCancionLibro.Text = "La piedra de cristal";
                    txtOpcion1.Text = "R.A. Salvatore";
                    txtOpcion2.Text = "Patrick Rothfuss";
                    txtOpcion3.Text = "Ursula K. Le Guin";
                    txtOpcion4.Text = "Michael Ende";

                    correcta = "R.A. Salvatore";
                    break;

                case 4:
                    txtCancionLibro.Text = "El nombre del viento";
                    txtOpcion1.Text = "Tad Williams";
                    txtOpcion2.Text = "C.S. Lewis";
                    txtOpcion3.Text = "Patrick Rothfuss";
                    txtOpcion4.Text = "Glen Cook";

                    correcta = "Patrick Rothfuss";
                    break;
            }
        }

        private void txtOpcion1_Click(object sender, EventArgs e)
        {
            if(txtOpcion1.Text == correcta)
            {
                txtOpcion1.Text = "¡CORRECTO!";
                txtOpcion1.BackColor = Color.Azure;
                porcentaje = +5;
            }

            else
            {
                txtOpcion1.Text = "¡HAS FALLADO!";
                txtOpcion1.BackColor = Color.Coral;
                porcentaje = -5;
            }
        }

        private void TxtOpcion2_Click(object sender, EventArgs e)
        {
            if (txtOpcion2.Text == correcta)
            {
                txtOpcion2.Text = "¡CORRECTO!";
                txtOpcion2.BackColor = Color.Azure;
                porcentaje = +5;
            }

            else
            {
                txtOpcion2.Text = "¡HAS FALLADO!";
                txtOpcion2.BackColor = Color.Coral;
                porcentaje = -5;
            }
        }

        private void TxtOpcion3_Click(object sender, EventArgs e)
        {
            if (txtOpcion3.Text == correcta)
            {
                txtOpcion3.Text = "¡CORRECTO!";
                txtOpcion3.BackColor = Color.Azure;
                porcentaje = +5;
            }

            else
            {
                txtOpcion3.Text = "¡HAS FALLADO!";
                txtOpcion3.BackColor = Color.Coral;
                porcentaje = -5;
            }
        }

        private void TxtOpcion4_Click(object sender, EventArgs e)
        {
            if (txtOpcion4.Text == correcta)
            {
                txtOpcion4.Text = "¡CORRECTO!";
                txtOpcion4.BackColor = Color.Azure;
                porcentaje = +5;
            }

            else
            {
                txtOpcion4.Text = "¡HAS FALLADO!";
                txtOpcion4.BackColor = Color.Coral;
                porcentaje = -5;
            }
        }

        private void txtOpcion2_TextChanged(object sender, EventArgs e)//no usado
        {

        }

        private void txtOpcion3_TextChanged(object sender, EventArgs e)//no usado
        {

        }

        private void txtOpcion4_TextChanged(object sender, EventArgs e)//no usado
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
            lblSuperior.Text = "Canción";
            lblInferior.Text = "Grupo";
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nombreGruposToolStripMenuItem.Checked)
                {
                    modoGrupos();
                }

            else if (nombreLibrosToolStripMenuItem.Checked)
                {
                    modoLibros();
                }
        }

        private void múltiplesOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void escribirRespuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOpcion1.ReadOnly = true;
            txtOpcion1.Visible = true;
            txtOpcion1.Visible = false;
            txtOpcion2.Visible = false;
            txtOpcion3.Visible = false;
            txtOpcion4.Visible = false;
            txtCorreccion.ReadOnly = false;

            if (nombreGruposToolStripMenuItem.Checked)
            {
                if(txtCorreccion.Text != correcta)
                {
                    txtCorreccion.Text = "¡HAS FALLADO!";
                    txtCorreccion.BackColor = Color.Coral;
                }
            }

            else
            {
                txtCorreccion.Text = "¡CORRECTO!";
                txtCorreccion.BackColor = Color.Azure;
            }


        }

       private void txtOpcion1_KeyDown(Object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

            }
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPorcentaje_TextChanged(object sender, EventArgs e)//caja para mostrar porcentaje
        {
            txtOpcion3.BackColor = Color.Aquamarine;
            txtPorcentaje.Text = porcentaje.ToString() + "%";
        }

        private void txtCorreccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
