﻿using SistemaInscripcionS10.Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaInscripcionS10.Datos;

namespace SistemaInscripcionS10.Datos
{
    internal class Postulantes
    {
        public String Nuevo_Postu(E_Postulante postu)
        {
            String? salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoPos", sqlCon);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = postu.NombreP;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = postu.ApellidoP;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = postu.TDocP;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = postu.DocP;

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
