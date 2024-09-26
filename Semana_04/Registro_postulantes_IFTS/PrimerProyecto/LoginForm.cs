using PrimerProyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_postulantes_IFTS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario" && txtPass.Text == "Admin123")
            {
                Form secondaryForm = new frmPrincipal();
                secondaryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
