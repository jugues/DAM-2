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
    public partial class FrmConsulta : Form
    {
        List<IElementoMultimedia> elementos;
        public FrmConsulta()
        {
            InitializeComponent();
        }

        public FrmConsulta(List<IElementoMultimedia> elementos)
        {
            InitializeComponent();
            this.elementos = elementos;
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        public void cargarElementos()
        {
            foreach(IElementoMultimedia i in elementos)
            {

                if(i.GetType == "Libro") //corregirlo
                {
                    ListView lv = listview.Items.Add(i.getTitulo());
                    lv.SubItems.Add()
                }
                
                
            }
        }
    }
}
