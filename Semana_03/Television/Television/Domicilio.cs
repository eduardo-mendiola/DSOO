using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Television
{
    internal class Domicilio
    {
        private String calle;
        private int numero;
        private String barrio;

        public Domicilio(string calle, int numero, string barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }

        public string Calle { get => calle; private set => calle = value; }
        public int Numero { get => numero; private set => numero = value; }
        public string Barrio { get => barrio; private set => barrio = value; }

        public override string ToString()
        {
            //return $"Calle: {Calle}, Número: {Numero}, Barrio: {Barrio}";

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
