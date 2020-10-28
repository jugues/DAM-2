using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaPrueba
{
    public partial class FrmAlta : FrmInicio
    {

        ArrayList miLista;
        public FrmAlta()
        {
            InitializeComponent();
        }

        public FrmAlta(ArrayList list)
        {
            miLista = list;
            InitializeComponent();
        }

        private void FrmHijo_Load(object sender, EventArgs e)
        {

        }
    }
}
