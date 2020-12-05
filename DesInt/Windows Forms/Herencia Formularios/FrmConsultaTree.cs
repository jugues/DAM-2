using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia_Formularios
{
    public partial class FrmConsultaTree : Herencia_Formularios.FrmPadre
    {
        public FrmConsultaTree()
        {
            InitializeComponent();
        }

        private void FrmConsultaTree_Load(object sender, EventArgs e)
        {
            foreach(Cliente c in misClientes)
            {
                string ciudad = c.getCiudad();

                if(!tvConsulta.Nodes.ContainsKey(ciudad))
                {
                    tvConsulta.Nodes.Add(c.getCiudad(), c.getCiudad(), 0);
                }
            }
        }

        private void tvConsulta_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach(Cliente c in misClientes)
            {
                string ciudad = c.getCiudad();
                string ciudadTree = tvConsulta.SelectedNode.Name;

                if(ciudadTree.Equals(ciudad))
                {
                    TreeNode n = tvConsulta.SelectedNode;
                    n.Nodes.Add(c.getNombre(), c.getNombre(), 1);
                }
            }
        }
    }
}
