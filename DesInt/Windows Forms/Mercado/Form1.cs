using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewPrueba
{
    public partial class Mercado : Form
    {
        ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);
        ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Center);
        public Mercado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lstvAlimentos.Items.Add(new ListViewItem("manzana", frutas));
            lstvAlimentos.Items.Add(new ListViewItem("pera", frutas));
            lstvAlimentos.Items.Add(new ListViewItem("mandarina", frutas));
            lstvAlimentos.Items.Add(new ListViewItem("kiwi", frutas));

            lstvAlimentos.Items.Add(new ListViewItem("ternera", carnes));
            lstvAlimentos.Items.Add(new ListViewItem("pollo frito", carnes));
            lstvAlimentos.Items.Add(new ListViewItem("pollo a la plancha", carnes));

            lstvAlimentos.Groups.Add(frutas);
            lstvAlimentos.Groups.Add(carnes);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(rbFrutas.Checked == true)
            {
                lstvAlimentos.Items.Add(new ListViewItem(tbAgregar.Text, frutas));
            }

            if(rbCarnes.Checked == true)
            {
                lstvAlimentos.Items.Add(new ListViewItem(tbAgregar.Text, carnes));
            }
        }
    }
}
