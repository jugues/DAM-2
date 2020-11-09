using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaControlesAdicionales
{
    //usar sortedList
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsColor_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void tsFuente_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.menuStrip1.Font = this.fontDialog1.Font;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Juli\\AppData\\Local\\Programs\\Opera GX\\launcher.exe");
        }

        private void timerBar_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
        }

        private void lbCajita_Validated(object sender, EventArgs e)
        {
            if (this.tbCajita.Text.Equals(""))
            {
                errorProvider1.SetError(tbCajita, "Debes rellenarlo");
            }
        }
    }
}
