using Registro_postulantes_IFTS;

namespace PrimerProyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los TextBox y ComboBox
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string tipo = cboComboBoxTipo.Text;
            string documento = txtDocumento.Text;

            // Crear un objeto Postulante con los datos
            Postulante postulante = new Postulante(nombre, apellido, tipo, documento);

            // Mostrar los datos en un MessageBox
            MessageBox.Show(postulante.ToString(), "Datos del Postulante");
        }
    }
}
