// Referencia a MySQL (se agrega como libreria)
using MySql.Data.MySqlClient;
//---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoLogin.Datos
{
    public class Conexion // La clase debe ser public
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        public Conexion()
        {
            this.baseDatos = "Instituto";
            this.servidor = Environment.GetEnvironmentVariable("DB_HOST_MYSQL");
            this.puerto = Environment.GetEnvironmentVariable("DB_PORT_MYSQL");
            this.usuario = Environment.GetEnvironmentVariable("DB_USER_MYSQL");
            this.clave = Environment.GetEnvironmentVariable("DB_PASSWORD_MYSQL");
        }

        // proceso de interacción

        public MySqlConnection CrearConexion()
        {
            // Instanciamos una conexión
            MySqlConnection? cadena = new MySqlConnection();

            // El bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex) 
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // Para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // Quiere decir que la conexión esta cerrada
            {
                con = new Conexion(); // Se crea una nueva
            }
            return con;
        }
    }
}
