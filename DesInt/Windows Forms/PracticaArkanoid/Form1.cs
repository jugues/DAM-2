using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaArkanoid
{
    public partial class Form1 : Form
    {

        bool goRight;
        bool goLeft;
        int speed;
        int ballX;
        int ballY;
        int score;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            initGame();
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        public void initGame()
        {
            score = 0;
            ballX = 5;
            ballY = 5;
            speed = 12;
            btnLabel.Text = "Puntuación: ";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnLabel.Text = "Puntuación: " + score;

            //mover barra
            if (goLeft == true && pbBarra.Left > 5) 
            {
                pbBarra.Left -= speed;
            }
            
            if(goRight == true && pbBarra.Left < 816)

            {
                pbBarra.Left += speed;
            }

            //mover bola y control de choque
            pbBola.Left += ballX;
            pbBola.Top += ballY;

            if(pbBola.Left < 0 || pbBola.Left > 815)
            {
                ballX = -ballX;
            }

            if(pbBola.Top < 0)
            {
                ballY = -ballY;
            }

            //controlar choque con barra 
            if(pbBola.Bounds.IntersectsWith(pbBarra.Bounds))
            {
                ballY = r.Next(5, 12) * -1; //hay que hacer negativo el número o no irá hacia arriba

                if(ballX < 0)
                {
                    ballX = r.Next(5, 12) * -1;
                }

                else
                {
                    ballX = r.Next(5, 12);
                }
            }

            //si chocamos con un bloque
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "block")
                {
                    if(pbBola.Bounds.IntersectsWith(x.Bounds))
                    {
                        score++;
                        ballY = -ballY;
                        this.Controls.Remove(x); //borramos el bloque
                    }
                }
            }

            //si ganamos
            if(score == 24)
            {
                gameOver("¡Victoria!");
            }

            //si perdemos 
            if(pbBola.Top > 700)
            {
                gameOver("¡Otra vez será!");
            }
        }

        private void gameOver(String msg)
        {
            timer1.Stop();
            btnLabel.Text = "Puntuación: " + score + " " + msg;
        }
    }
}
