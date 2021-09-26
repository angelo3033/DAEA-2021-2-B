using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab04
{
    public partial class Curso : Form
    {
        SqlConnection conn;
        public Curso(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListarC_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "SELECT * FROM Course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            MessageBox.Show(conn.State.ToString());
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String Title = txtCurso.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarCursoTitulo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Title";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = Title;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexcion esta cerrada");
            }
        }
    }
}
