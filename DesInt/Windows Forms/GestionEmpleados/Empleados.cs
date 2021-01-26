using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        IDbConnection ctn;
        ListViewItem r;

        private void Form1_Load(object sender, EventArgs e)
        {
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Juli\\Desktop\\Archivos\\Interfaces Bases\\Emple.mdb";
            ctn.Open();
            LlenarlistDepart();
            llenarlistabusqueda();
            Llenarlistid();
        }

        private void LlenarlistDepart()
        {
            listBoxDepartamento.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            cmd.CommandText = " select * from depart";
            OleDbDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                listBoxDepartamento.Items.Add(lector["dept_no"]);
            }
        }
        private void LlenarlistLocali()
        {
            listBoxLocalizacion.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            cmd.CommandText = " select distinct loc from depart where dept_no = @depart";
            
            cmd.Parameters.AddWithValue("@depart", Convert.ToInt32(listBoxDepartamento.SelectedItem.ToString()));
            OleDbDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                listBoxLocalizacion.Items.Add(lector["LOC"]);
            }

        }
        private void Llenarlistid()
        {
            listBox2.Visible = false;
            listBoxLocalizacion.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            cmd.CommandText = " select emp_no from emple";

            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                listBox2.Items.Add(lector["emp_no"]);
            }
        }

        private void listBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarlistLocali();
            limpiarlistbox();
            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            string sql = " SELECT * FROM EMPLE, depart where emple.dept_no=depart.dept_no and depart.dept_no = ?";
            cmd.CommandText = sql;


            OleDbParameter paramDept = new OleDbParameter("@DeptNo", listBoxDepartamento.SelectedItem.ToString());
            paramDept.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(paramDept);
            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                r = listViewape.Items.Add(lector["APELLIDO"].ToString());
                r.SubItems.Add(lector["OFICIO"].ToString()); 
                listViewOfi.Items.Add(lector["OFICIO"].ToString());

                r.SubItems.Add(lector["COMISION"].ToString()); listViewComision.Items.Add(lector["COMISION"].ToString());

                r.SubItems.Add(lector["FECHA_ALT"].ToString()); listViewFechaAlta.Items.Add(lector["FECHA_ALT"].ToString());

                r.SubItems.Add(lector["SALARIO"].ToString()); listViewSalario.Items.Add(lector["SALARIO"].ToString());


            }

        }
        private void limpiarlistbox()
        {
            listViewape.Items.Clear();
            listViewSalario.Items.Clear();
            listViewOfi.Items.Clear();
            listViewFechaAlta.Items.Clear();
            listViewComision.Items.Clear();
        }
        private void limpiartextbox()
        {
            textBoxApellidos.Text = "";
            textBoxComision.Text = "";
            textBoxFechaAlta.Text = "";
            textBoxOficio.Text = "";
            textBoxSalario.Text = "";

        }


        private void listViewape_Click(object sender, EventArgs e)
        {
            limpiartextbox();
            ListViewItem r = listViewape.SelectedItems[0];
            ListViewItem.ListViewSubItemCollection item = r.SubItems;



            textBoxApellidos.Text = item[0].Text.ToString();
            textBoxOficio.Text = item[1].Text.ToString();
            textBoxComision.Text = item[2].Text.ToString();
            textBoxFechaAlta.Text = item[3].Text.ToString();
            textBoxSalario.Text = item[4].Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string apellido = textBoxApellidos.Text; string oficio = textBoxOficio.Text;
            string dir = tbBuscarPor.Text; string fecha = textBoxFechaAlta.Text;
            string salario = textBoxSalario.Text; string comision = textBoxComision.Text;

            Decimal salariodec = Decimal.Parse(salario);


            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            String query = "INSERT INTO EMPLE(emp_no, apellido, oficio, dir, salario, comision, dept_no) VALUES (@emple_no,@apellido,@oficio, @dir,@fecha,@salario,@comision,@dept_no)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@emple_no", numeroempleado());
            cmd.Parameters.AddWithValue("@apellido", textBoxApellidos.Text);
            cmd.Parameters.AddWithValue("@oficio", textBoxOficio.Text);
            cmd.Parameters.AddWithValue("@dir", 0);
            cmd.Parameters.AddWithValue("@salario", salariodec);
            cmd.Parameters.AddWithValue("@comision", Convert.ToDecimal(textBoxComision.Text));
            cmd.Parameters.AddWithValue("@dept_no", Convert.ToInt32(listBoxDepartamento.SelectedItem.ToString()));

            int result = cmd.ExecuteNonQuery();

            
            if (result < 0) {
               MessageBox.Show("Error insertando el empleado en la base de datos");
            }
            else{
                MessageBox.Show("Empleado creado con exito!");
            }

        }

        public int numeroempleado()
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;
            cmd.CommandText = " select max(emp_no)" +
                "from emple";
              OleDbDataReader lector = cmd.ExecuteReader();
            String numero ="";
            while (lector.Read())
            {
                numero = lector[0].ToString();
            }
            return Convert.ToInt32(numero);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Seleccione un id de empleado");
            listBox2.Visible = true;

            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            String query = "DELETE FROM EMPLE where emp_no = @emp_no";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@emp_no", listBox2.SelectedItem);
            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string apellido = textBoxApellidos.Text; string oficio = textBoxOficio.Text;
            string dir = tbBuscarPor.Text; string fecha = textBoxFechaAlta.Text;
            string salario = textBoxSalario.Text; string comision = textBoxComision.Text;

            Decimal salariodec = Decimal.Parse(salario);


            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;

            String query = "UPDATE EMPLE SET APELLIDO = @apellido, OFICIO = @oficio, DIR = @dir, SALARIO = @salario, COMISION = @comision, dept_no = @dept_no WHERE APELLIDO = @apellido";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@emple_no", numeroempleado());
            cmd.Parameters.AddWithValue("@apellido", listViewape.SelectedItems[0].Text);
            cmd.Parameters.AddWithValue("@oficio", textBoxOficio.Text);
            cmd.Parameters.AddWithValue("@dir", 0);
            cmd.Parameters.AddWithValue("@salario", salariodec);
            cmd.Parameters.AddWithValue("@comision", Convert.ToDecimal(textBoxComision.Text));
            cmd.Parameters.AddWithValue("@dept_no", Convert.ToInt32(listBoxDepartamento.SelectedItem.ToString()));

            int result = cmd.ExecuteNonQuery();

            // Check Error
            if (result < 0)
            {
                MessageBox.Show("Error insertando el empleado en la base de datos, compruebe los campos");
            }
            else
            {
                MessageBox.Show("Empleado creado con exito!");
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {

        }
        public void llenarlistabusqueda()
        {
            listBoxBuscarpor.Items.Add("APELLIDO");
            listBoxBuscarpor.Items.Add("OFICIO");
            listBoxBuscarpor.Items.Add("DIR");
            listBoxBuscarpor.Items.Add("FECHA ALTA");
            listBoxBuscarpor.Items.Add("SALARIO");
            listBoxBuscarpor.Items.Add("COMISION");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand();
            cmd.Connection = (OleDbConnection)ctn;
            string aux = listBoxBuscarpor.SelectedItem.ToString();

            string sql = " SELECT * FROM EMPLE WHERE'" + aux + "'= @texto";
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@texto", tbBuscarPor.Text);


            OleDbDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                r = listViewape.Items.Add(lector["APELLIDO"].ToString());
                r.SubItems.Add(lector["OFICIO"].ToString());
                listViewOfi.Items.Add(lector["OFICIO"].ToString());

                r.SubItems.Add(lector["COMISION"].ToString()); listViewComision.Items.Add(lector["COMISION"].ToString());

                r.SubItems.Add(lector["FECHA_ALT"].ToString()); listViewFechaAlta.Items.Add(lector["FECHA_ALT"].ToString());

                r.SubItems.Add(lector["SALARIO"].ToString()); listViewSalario.Items.Add(lector["SALARIO"].ToString());

            }
        }
    }
    
}
