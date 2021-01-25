using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Conexion_Emple
{
    public partial class Inicio : Form
    {
        OleDbConnection ctn;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + 
                "Data Source=C:\\Users\\Juli\\Desktop\\Archivos\\Interfaces Bases\\Nwind.mdb";
            ctn.Open();
            MessageBox.Show(ctn.State.ToString());

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            IDbCommand cmd = ctn.CreateCommand(); 
            cmd.CommandText = "select * from products";
            IDataReader reader = cmd.ExecuteReader(); //interfaz válida para cualquier tipo de conexión

            while(reader.Read()) //mientras queden registros por leer
            {
                this.listboxProductos.Items.Add(reader.GetString(1)); //cogemos la segunda columna del datareader
            }
        }

        private void btnConsultaFrank_Click(object sender, EventArgs e) //otra forma de consultar
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = ctn;
            cmd.CommandText = "select count(orderid) from orders where customerid = 'FRANK'";
            MessageBox.Show(cmd.ExecuteScalar().ToString()); //Scalar es eficiente para números
        }
    }
}
