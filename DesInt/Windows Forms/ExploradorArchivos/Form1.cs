using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExploradorArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargamos las unidades y les ponemos el icono correspondiente
            String[] drives = Directory.GetLogicalDrives();
            foreach(String u in drives)
            {
                TreeNode n = treeviewDevices.Nodes.Add(u);
                n.ImageIndex = 0;
                n.SelectedImageIndex = 0;
            }
        }

        private void treeviewDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //meter los hijos de cada nodo

            String [] directories = Directory.GetDirectories(e.Node.Text); //directorio del nodo pinchado
            foreach (String d in directories)
            {
                //String sd = d; 
                //sd = sd.Substring(0, sd.LastIndexOf('/'));
                TreeNode t = e.Node.Nodes.Add(d);
                t.ImageIndex = 1;
                t.SelectedImageIndex = 1;
                t.Tag = d;
            }

            //mostrar los ficheros en el listview
            String[] files = Directory.GetFiles(e.Node.Text);
        }
    }
}
