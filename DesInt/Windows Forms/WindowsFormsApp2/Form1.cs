using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPulsa_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if(boton.Name.Equals("BtnPulsa"))
            {
                textBox1.Text = "Hola, mundo";
            }

            else
            {
                textBox1.Text = "Hola, mundo2";
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
