using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDragDrop
{
    public partial class FrmPrincipal : Form
    {
        int index = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            string[] items1 = {"Ranma 1/2", "Inuyasha", "Maison Ikkoku"};
            checkedListBox1.Items.AddRange(items1);
        }

        private void checkedListBox1_MouseDown(object sender, MouseEventArgs e) //efecto del drag and drop
        {
            CheckedListBox chk1 = sender as CheckedListBox;
            index = chk1.IndexFromPoint(e.X, e.Y);

            if(index >= 0 && e.Button == MouseButtons.Left)
            {
                chk1.DoDragDrop(chk1.Items[index].ToString(), DragDropEffects.Move);
            }
        }

        private void checkedListBox2_DragDrop(object sender, DragEventArgs e) //sobre el control que recibe los datos
        {
            CheckedListBox chk2 = sender as CheckedListBox;
            chk2.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            checkedListBox1.Items.RemoveAt(index);
        }

        private void checkedListBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                e.Effect = DragDropEffects.Move;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /* private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox listBox1 = sender as ListBox;
            listBox1.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            checkedListBox1.Items.RemoveAt(index);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                e.Effect = DragDropEffects.Move;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    } */
}
