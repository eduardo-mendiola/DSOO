using DiseñoLoginS8;

namespace DiseñoLoginS8
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }
        //private void btnIngresar_Click(object sender, EventArgs e)
        //{
        //    // Obtener los valores ingresados en los TextBox y ComboBox
        //    string nombre = txtNombre2.Text;
        //    string apellido = txtApellido2.Text;
        //    string tipo = cboComboBoxTipo2.Text;
        //    string documento = txtDocumento2.Text;

        //    // Crear un objeto Postulante con los datos
        //    Postulante postulante = new Postulante(nombre, apellido, tipo, documento);

        //    // Mostrar los datos en un MessageBox
        //    MessageBox.Show(postulante.ToString(), "Datos del Postulante");
        //}

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string tipo = cboComboBoxTipo.Text;
            string documento = txtDocumento.Text;

            int renglon = dtgvPostulante.Rows.Add();

            dtgvPostulante.Rows[renglon].Cells[0].Value = nombre;
            dtgvPostulante.Rows[renglon].Cells[1].Value = apellido;
            dtgvPostulante.Rows[renglon].Cells[2].Value = tipo;
            dtgvPostulante.Rows[renglon].Cells[3].Value = documento;

            txtNombre.Text = "";
            txtApellido.Text = "";
            cboComboBoxTipo.Text = "";
            txtDocumento.Text = "";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboComboBoxTipo.Text = "";
            txtDocumento.Text = "";
        }
    }
}
