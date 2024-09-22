// See https://aka.ms/new-console-template for more information
using AdmEmpleados;


Empleado empleado1 = new Empleado("Apolo", 20, "Principal");
Empresa empresa1 = new Empresa("Zarit", empleado1);

empresa1.EmpleadoPrincipal.MostrarInformacion();