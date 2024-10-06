using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoLoginS8
{
    internal class Postulante
    {
        public String nombre { get; private set; }
        public String apellido { get; private set; }
        public String tipo { get; private set; }
        public String documento { get; private set; }

        public Postulante(string nombre, string apellido, string tipo, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.documento = documento;
        }

        public override string? ToString()
        {
            // return $"Nombre2: {nombre}, Apellido2: {apellido}, Tipo2: {tipo}, Documento2: {documento}"; 
            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            string result = "";

            foreach (var prop in properties)
            {
                result += $"{prop.Name}: {prop.GetValue(this, null)}\n";
            }

            return result;
        }
    }
}
