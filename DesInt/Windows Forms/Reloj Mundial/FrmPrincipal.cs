using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Reloj_Mundial
{
    public partial class FrmPrincipal : Form
    {

        private SortedList<String, String> paises = new SortedList<string, string>();
        private String horaNueva = "";
        ListBox listboxBorrar = new ListBox();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void AñadirTsItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem adicionPais = new ToolStripMenuItem();
            string nombrePaisNuevo = Interaction.InputBox("Nombre del país", "Nuevo país", "");
            string horaPaisNuevo = Interaction.InputBox("Diferencia horaria", "Nuevo país", "");
            adicionPais.Text = nombrePaisNuevo;
            adicionPais.Tag = horaPaisNuevo;
            paísToolStripMenuItem.DropDownItems.Add(adicionPais);
            paises.Add(nombrePaisNuevo, horaPaisNuevo);
            adicionPais.Click += new System.EventHandler(this.cambiarHora);

        }

        public void cambiarHora(Object sender, EventArgs e)
        {
            Timer timer2 = new Timer();

            foreach(var pais in paises)
            {
                if (sender.ToString().Equals(pais.Key))
                {
                    timer2.Enabled = true;
                    lblZona.Text = pais.Key;
                    horaNueva = pais.Value;
                    timer2.Tick += new System.EventHandler(this.ponerHora);

                }
            }
        }

        public void ponerHora(Object sender, EventArgs e)
        {
            double hora = Convert.ToDouble(horaNueva);
            tbZona.Text = DateTime.Now.AddHours(hora).ToString("HH:mm:ss");
        }
    }
}
