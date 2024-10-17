using SistemaInscripcionS9;

namespace SistemaInscripcionS9
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        /* __________________ VARIABLES tipo INTERNAL ______________________
         Ser�n accesibles desde el ensamblado en el cual est�n declarados
         y tampoco se pueden utilizar en el interior de una funci�n.
        ____________________________________________________________________ 
        */

        internal String? rol;
        internal String? usuario;

        //private void frmPrincipal_Load(object sender, EventArgs e)
        //{
        //    // Verificar si los valores de usuario y rol no son nulos antes de asignarlos al label
        //    if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(rol))
        //    {
        //        lblIngreso.Text = $"USUARIO: {usuario} ({rol})";
        //    }
        //    else
        //    {
        //        lblIngreso.Text = "USUARIO: Informaci�n no disponible";
        //    }
        //}

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = $"USUARIO: {usuario} ({rol})";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Notifica a todos los surtidores de mensajes que deben terminar
               y a continuaci�n, cierra todas las ventanas de la aplicaci�n.
            ------------------------------------------------------------------
            */

            Application.Exit();
        }

        // Abre el formulario de inscripci�n
        private void btnInscribir_Click(Object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Owner = this;  // Establecer frmPrincipal como due�o
            inscripcion.Show();
            this.Hide();
        }
    }
}
