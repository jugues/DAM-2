//faltan los botones de la memoria y el de la raíz cuadrada

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //zona de variables 
        double num1, num2, resul;
        string signo;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            signo = "/";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            signo = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            signo = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void ButC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            signo = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);

            switch (signo)
            {
                case "+":
                    resul = num1 + num2;
                    textBox1.Text = resul.ToString();
                    break;

                case "-":
                    resul = num1 - num2;
                    textBox1.Text = resul.ToString();
                    break;

                case "*":
                    resul = num1 * num2;
                    textBox1.Text = resul.ToString();
                    break;

                case "/":
                    try
                    {
                        resul = num1 / num2;
                        textBox1.Text = resul.ToString();
                    }

                    catch(DivideByZeroException)
                    {
                        Console.WriteLine("Se ha intentado dividir un número por cero.");
                    }
                    break;
            }
        }
    }
}
