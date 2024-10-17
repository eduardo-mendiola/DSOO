using SistemaInscripcionS10;
using SistemaInscripcionS10.Datos.Entidades;

namespace SistemaInscripcionS10
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();  // Mostrá el formulario principal (dueño)
            this.Close();       // Cerrá el formulario actual
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String respuesta;
                E_Postulante postu = new E_Postulante();

                postu.NombreP = txtNombre.Text;
                postu.ApellidoP = txtApellido.Text;
                postu.DocP = Convert.ToInt32(txtDocumento.Text);
                postu.TDocP = cboTipo.Text;

                // Instaciamos para usar el método dentro de postulantes
                Datos.Postulantes postulantes = new Datos.Postulantes();

                respuesta = postulantes.Nuevo_Postu(postu);

                bool esnumero = int.TryParse(respuesta, out int codigo);


                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        /* =============================================
         * Limpiamos los objetos para un nuevo ingreso
         * =============================================
         */
            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDocumento.Text = "";
                cboTipo.Text = "";
                txtNombre.Focus();
            }


        }
    }
