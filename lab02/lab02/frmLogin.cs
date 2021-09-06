using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string usuario = "angelo3033";
        string clave = "123456";

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtPassword.Text;

            if (user.Equals(usuario))
            {
                if (password.Equals(clave))
                {
                    PrincipalMDI principal = new PrincipalMDI();
                    principal.Show();
                    this.Hide();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
