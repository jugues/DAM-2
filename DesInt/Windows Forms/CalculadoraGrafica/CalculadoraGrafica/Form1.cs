//no está del todo completo

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
        double Num1, Num2, Resul, Memoria;
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

        private void Button20_Click(object sender, EventArgs e)//1 entre x
        {
            if(textBox1.Text != "")
            {
                Num1 = double.Parse(textBox1.Text);
                try
                {
                    Num2 = 1 / Num1;
                    textBox1.Text = Num2.ToString();
                }

                catch (DivideByZeroException)

                {
                    Console.WriteLine("No puedes dividir uno entre cero.");
                }
            }

            else
            {
                try
                {
                    Num2 = 1 / Num1;
                    textBox1.Text = Num2.ToString();
                }
                catch(FormatException)
                {
                    Console.WriteLine("Debes introducir primero un número antes de pulsar el botón.");
                }
            }


        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button7_Click(object sender, EventArgs e)//memory clear
        {
            Num1 = 0;
            Num2 = 0;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            signo = "/";
            Num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)//memory recall
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
            Num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button9_Click(object sender, EventArgs e)//memory storage
        {
            Memoria = double.Parse(textBox1.Text);
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
            Num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button10_Click(object sender, EventArgs e)//m+
        {
            if(Num1>0)
            {
                Resul = Memoria + Num1;
            }

            else
            {
                Resul = Memoria + Num2;
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void ButC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Num1 = 0;
            Num2 = 0;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            signo = "+";
            Num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            Num2 = double.Parse(textBox1.Text);

            switch (signo)
            {
                case "+":
                    Resul = Num1 + Num2;
                    textBox1.Text = Resul.ToString();
                    break;

                case "-":
                    Resul = Num1 - Num2;
                    textBox1.Text = Resul.ToString();
                    break;

                case "*":
                    Resul = Num1 * Num2;
                    textBox1.Text = Resul.ToString();
                    break;

                case "/":
                    try
                    {
                        Resul = Num1 / Num2;
                        textBox1.Text = Resul.ToString();
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
