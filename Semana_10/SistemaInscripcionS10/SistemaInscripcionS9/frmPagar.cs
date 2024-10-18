using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using SistemaInscripcionS10.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcionS10
{
    public partial class frmPagar : Form
    {
        public frmFactura doc = new frmFactura();
        public frmPagar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Owner = this.Owner;  // Asigna el Owner del formulario actual
            doc.Show();
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                String query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                /*
                 ------------------------------------------------------------------
                Consulta simple que proyecta los datos necesarios para rellenar el 
                documento.
                En este caso se trata del comprobante de pago del curso.
                -------------------------------------------------------------------
                 */

                query = ("select idinscri, nombre, concat(nombrep, ' ', apellidop), precio, e.fecha " +
                         "from inscripcion i " +
                         "inner join edicion e on i.idEdicion = e.idEdicion " +
                         "inner join curso c on c.ncurso = e.ncurso " +
                         "inner join alumno a on a.legajo = i.legajo " +
                         "inner join postulante p on p.NPostu = a.Npostu " +
                         "where idinscri = " + txtNro.Text); // <<<----- Usamos el dato ingresado por el usuario.

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // Usamos la consulta y la conexion. 
                Console.WriteLine(query); // borrar

                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA

                    doc.numero_f = reader.GetInt32(0);
                    doc.curso_f = reader.GetString(1);
                    doc.alumno_f = reader.GetString(2);
                    doc.monto_f = reader.GetFloat(3);
                    doc.fecha_f = reader.GetDateTime(4);

                    if (optEfvo.Checked == true) // Evaluamos que opción es la seleccionada
                    {
                        doc.forma_f = "Efectivo";
                        /* -------------------------------------------
                         * Pago en efvo se descuenta 10%
                         * -------------------------------------------
                         */
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }
                    btnComprobante.Enabled = true;

                    
                    MessageBox.Show("Pago realizado exitosamente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Despues borrar, es solo para ver si se estan cargando los valores
                    System.Diagnostics.Debug.WriteLine(query);
                    System.Diagnostics.Debug.WriteLine($"{doc.numero_f} | {doc.curso_f} | {doc.alumno_f} | {doc.monto_f} | {doc.fecha_f}");


                }
                else
                {
                    MessageBox.Show("Número de inscripción inexistente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
