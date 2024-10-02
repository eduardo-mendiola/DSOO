using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoLogin.Datos
{
    internal class Usuarios
    {
        // Creamos un metodo que retorne una tabla con la informnación
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resuldato; // Variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // El comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexión

                MySqlCommand comando = new MySqlCommand("ingresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                // Definimos los parametros que tiene el procedura

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;

                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value=P_Usu;

                // Abrimos la conexion
                sqlCon.Open();
                resuldato = comando.ExecuteReader();
                // Almacenamos el resultado en la variable
                tabla.Load(resuldato); // Cargamos la tabla con el resultado

                // De esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL


                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            // Como proceso final
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
