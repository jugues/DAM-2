using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRepeticion
{
    public partial class FrmContacto : Form //falta el combobox/menú contextual
    {
        public List<Contacto> misContactos = new List<Contacto>();
        string rutaFichero = "C:\\Users\\Juli\\source\\repos\\ExamenRepeticion\\contactosNuevo.txt";
        public FrmContacto()
        {
            InitializeComponent();
        }

        public FrmContacto(List<Contacto> l)
        {
            InitializeComponent();
            misContactos = l; 
            listarContactos();
        }

        private void listarContactos()
        {
            listViewContactos.Items.Clear();
            int i = 0;
            foreach(Contacto c in misContactos)
            {
                ListViewItem lvi = new ListViewItem(c.Nombre, i);
                listViewContactos.Items.Add(lvi);
                lvi.SubItems.Add(c.Tipo);
                lvi.SubItems.Add(c.Telefono);
                lvi.SubItems.Add(c.Ciudad);
                lvi.SubItems.Add(c.Contact);
                i++;
            }
            listViewContactos.Sort(); //ordenar por nombre, FALTA
        }

        private void FrmContacto_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter(rutaFichero);

            foreach (Contacto c in misContactos)
            {
                sw.WriteLine(c.Tipo + "," + c.Nombre + "," + c.Telefono + "," + c.Ciudad + "," + c.Contact);
            }

            sw.Close();

            string message = "¿Desea salir realmente del formulario?";
            string caption = "Cerrando Formulario";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            else
            {
                Application.Exit(); //cambiar por environment
            }
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            string aBuscar = tbContacto.Text;
            string message, caption;
            bool salir = false;

            while(salir == false)
            {
                foreach (Contacto c in misContactos) //no está bien del todo; arreglar al final y añadir ciudad
                {
                    if (c.Nombre.Equals(aBuscar) || c.Contact.Equals(aBuscar))
                    {
                        message = "Tu búsqueda se encuentra en la lista de contactos";
                        caption = "Resultado";
                        MessageBox.Show(message, caption);
                        salir = true;
                    }

                    /* else
                    {
                        message = "Tu búsqueda no se encuentra en la lista de contactos";
                        caption = "Resultado";
                        MessageBox.Show(message, caption);
                        salir = true;
                    } */
                }
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e) 
        {
            if(listViewContactos.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("¿Borrar de la colección el elemento seleccionado?", "Eliminar contacto", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for(int i = listViewContactos.SelectedItems.Count -1; i>=0; i--)
                    {
                        listViewContactos.Items.Remove(listViewContactos.SelectedItems[i]); //borramos del listview
                        misContactos.RemoveAt(i); //borramos de la colección
                    }
                }
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            Contacto editando;
            foreach (Contacto c in misContactos)
            {
                string aux = listViewContactos.SelectedItems[0].Text;
                if (c.Nombre.Equals(aux))
                {
                    editando = c;
                    FrmDetalle f = new FrmDetalle(misContactos, editando);
                    f.Show();
                    Hide();
                }
            }
        }
    }
}
