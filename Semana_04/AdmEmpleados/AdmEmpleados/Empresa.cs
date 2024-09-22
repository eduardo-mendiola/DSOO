using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmEmpleados
{
    internal class Empresa
    {
        private string nombre;
        private Empleado empleadoPrincipal;

        public Empresa(string nombre, Empleado empleadoPrincipal)
        {
            this.nombre = nombre;
            this.empleadoPrincipal = empleadoPrincipal;
        }

        public string Nombre { get => nombre; private set => nombre = value; }
        public Empleado EmpleadoPrincipal { get => empleadoPrincipal; private set => empleadoPrincipal = value; }

        
    }
}
