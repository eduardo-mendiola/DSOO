using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmEmpleados
{
    internal class Empleado
    {
        private string nombre;
        private int edad;
        private string cargo;

        public Empleado(string nombre, int edad, string cargo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cargo = cargo;
        }

        public string Nombre { get => nombre; private set => nombre = value; }
        public int Edad { get => edad; private set => edad = value; }
        public string Cargo { get => cargo; private set => cargo = value; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre} \nEdad: {edad} \nCardo: {cargo}");
        }
    }
}
