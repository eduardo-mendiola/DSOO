using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using SistemaInscripcionS10.Datos;
using SistemaInscripcionS10.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcionS10
{
    public partial class frmAsignar : Form
    {
        public frmAsignar()
        {
            InitializeComponent();
        }

        private void frmAsignar_Load(object sender, EventArgs e)
        {
            CargarGrilla(); // Llamada al procedimiento
        }

        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "select e.idEdicion, c.nombre, e.fecha, concat(d.NombreD, ' ', d.ApellidoD) as Docente, c.precio " +
                        "from curso c " +
                        "inner join edicion e on c.NCurso = e.NCurso " +
                        "inner join docente d on e.docente = d.NDocente " +
                        "where e.fecha > curdate() " +
                        "order by c.nombre; ";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvCurso.Rows.Add();
                        dtgvCurso.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtgvCurso.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvCurso.Rows[renglon].Cells[2].Value = reader.GetDateTime(2);
                        dtgvCurso.Rows[renglon].Cells[3].Value = reader.GetString(3);
                        dtgvCurso.Rows[renglon].Cells[4].Value = reader.GetDouble(4);

                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnVolverAsignar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();  // Mostrá el formulario principal (dueño)
            this.Close();       // Cerrá el formulario actual
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtNumLegajo.Text == "" || txtIdCurso.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String respuesta;
                E_Asignar asignacion = new E_Asignar();

                asignacion.NumLegajo = Convert.ToInt32(txtNumLegajo.Text);
                asignacion.IdCurso = Convert.ToInt32(txtIdCurso.Text);

                // Instaciamos para usar el método dentro de postulantes
                Asignacion asignar = new Asignacion();

                respuesta = asignar.Nueva_Asignacion(asignacion);

                bool esnumero = int.TryParse(respuesta, out int codigo);


                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA ESTA INSCRIPTO EL EL CURSO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se asigno con exito el legajo Nro " + txtNumLegajo.Text + " al curso Id: " + txtIdCurso.Text, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

      
        private void btnLimpiarAsignacion_Click(object sender, EventArgs e)
        {
            txtNumLegajo.Text = "";
            txtIdCurso.Text = "";
        }
    }

}
