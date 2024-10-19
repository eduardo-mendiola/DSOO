using MySql.Data.MySqlClient;
using SistemaInscripcionS10.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcionS10.Datos
{
    internal class Asignacion
    {
        public String Nueva_Asignacion(E_Asignar asignacion)
        {
            String? salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("InsCurso", sqlCon);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("numLeg", MySqlDbType.Int32).Value = asignacion.NumLegajo;
                comando.Parameters.Add("idEdi", MySqlDbType.Int32).Value = asignacion.IdCurso;
                

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
         
            // Como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
