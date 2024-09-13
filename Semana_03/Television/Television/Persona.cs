using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Television
{
    internal class Persona
    {
        private String nombre;
        private Domicilio domicilio;
        private Televisor tele;

        public Persona(string nombre, Domicilio domicilio, Televisor tele)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.tele = tele;
        }

        public string Nombre { get => nombre; private set => nombre = value; }
        internal Domicilio Domicilio { get => domicilio; private set => domicilio = value; }
        internal Televisor Tele { get => tele; private set => tele = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            //return $"Nombre {Nombre}, Domicilio: {Domicilio}, Televisor: {Tele}";

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
