using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using SistemaInscripcionS10.Datos;
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
                query = "select c.nombre, e.fecha, concat(d.NombreD, ' ', d.ApellidoD) as Docente, c.precio " +
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
                        dtgvCurso.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvCurso.Rows[renglon].Cells[1].Value = reader.GetDateTime(1);
                        dtgvCurso.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvCurso.Rows[renglon].Cells[3].Value = reader.GetDouble(3);

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

    }

}
