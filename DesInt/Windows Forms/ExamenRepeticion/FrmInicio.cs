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

namespace ExamenRepeticion
{
    public partial class FrmInicio : Form
    {
        private List<Contacto> lista = new List<Contacto>();
        string archivo = "C:\\Users\\Juli\\source\\repos\\ExamenRepeticion\\contactos.txt";
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "¿Seguro que quiere cerrar el formulario?";
            string caption = "AVISO";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "¿Desea salir realmente del formulario?";
            string caption = "Cerrando Formulario";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            //guardar también la lista en el fichero (ver ejemplo examen Daniel)
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContacto f = new FrmContacto(lista);
            f.Show();
            Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            try
            {
                leerFichero();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido una excepción.");
            }
        }

        public void leerFichero()
        {
            FileInfo fInfo = new FileInfo(archivo); //para poder manipular el fichero debidamente
            if(fInfo.Exists)
            {
                StreamReader str = fInfo.OpenText();
                string linea = str.ReadLine(); //obtenemos el primer contacto
                while(linea != null)
                {
                    string[] datos = linea.Split(',');
                    switch (datos[0].Trim())
                    {
                        case "A":
                            Contacto amigo = new Contacto(datos[0], datos[1], datos[2], datos[3], "");
                            lista.Add(amigo);
                            break;
                        case "E":
                            Contacto empresa = new Contacto(datos[0], datos[1], datos[2], datos[3], datos[4]);
                            lista.Add(empresa);
                            break;
                    }

                    linea = str.ReadLine(); //nos ponemos en la siguiente linea
                }

                str.Close();
            }

            else //si no encuentra el archivo
            {
                MessageBox.Show("No se ha encontrado el fichero, " + "añádelo y vuelve a iniciar el programa.");
            }
        }
    }
}
