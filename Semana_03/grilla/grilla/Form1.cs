namespace grilla
{
    public partial class Form1 : Form
    {
        int nro; // Variable que se usan para cualquier procedimiento de este formulario

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            // Agregar un renglon para la escritura
            int renglon = dtgvDatos.Rows.Add();
            // Colocamos los datos en las columnas de esa fila
            dtgvDatos.Rows[renglon].Cells[0].Value = txtCodigo.Text;
            dtgvDatos.Rows[renglon].Cells[1].Value = txtNombre.Text;
            dtgvDatos.Rows[renglon].Cells[2].Value = txtCantidad.Text;
            // Blanqueo de los textBox
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            // El foco se instala en el objeto
            txtCodigo.Focus();

        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nro = e.RowIndex; // Muestra la posición de la fila seleccionada
            if (nro != -1)
            {
                MessageBox.Show((string)dtgvDatos.Rows[nro].Cells
                [1].Value);
            }
            else
            {
                MessageBox.Show("Selecciono el ENCABEZADO");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dtgvDatos.Rows.RemoveAt(nro);
        }
    }
}
