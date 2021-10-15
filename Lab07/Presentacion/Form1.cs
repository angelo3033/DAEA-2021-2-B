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
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            
            String FirstName = txtNombre.Text;
            dt = np.Get(FirstName);

            dgDatos.DataSource = dt;
            dgDatos.Refresh();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
