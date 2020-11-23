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
            loadFolders();
        }

        private void treeviewDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //meter los hijos de cada nodo


            try
            {
                String[] directories = Directory.GetDirectories(e.Node.Text); //directorio del nodo pinchado
                foreach (String d in directories)
                {
                    //String sd = d; 
                    //sd = sd.Substring(0, sd.LastIndexOf('/'));
                    TreeNode t = e.Node.Nodes.Add(d);
                    t.ImageIndex = 1;
                    t.SelectedImageIndex = 1;
                    t.Tag = d;
                    listviewFiles.Items.Clear();
                    listviewFiles.Refresh();
                }

                //mostrar archivos de las carpetas
                DirectoryInfo dInfo = new DirectoryInfo((string)e.Node.Text);
                foreach (FileInfo f in dInfo.GetFiles())
                {
                    //var created = f.CreationTime;
                    //var lastModified = f.LastWriteTime;
                    ListViewItem lv = listviewFiles.Items.Add(f.Name);
                    lv.SubItems.Add(f.CreationTime.ToString());
                    lv.SubItems.Add(f.LastWriteTime.ToString());
                    lv.SubItems.Add(f.LastAccessTime.ToString());

                }

                //mostrar los ficheros en el listview
                String[] files = Directory.GetFiles(e.Node.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("You don't have permission to access here.");
            }
            
        }

        public void loadFolders()
        {
            //cargamos las unidades y les ponemos el icono correspondiente
            String[] drives = Directory.GetLogicalDrives();
            foreach (String u in drives)
            {
                TreeNode n = treeviewDevices.Nodes.Add(u);
                n.ImageIndex = 0;
                n.SelectedImageIndex = 0;
            }
        }
    }
}
