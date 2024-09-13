using System;

namespace Television
{
    internal class Test
    {
        static void Main(string[] args)

        {

            try
            {
                Televisor televisor1 = new Televisor("Sony", "Supervison 2000", 32);

                Domicilio domicilio1 = new Domicilio("Jonte", 5299, "Monte Castro");

                Persona persona1 = new Persona("Facundo", domicilio1, televisor1);
                Persona persona2 = new Persona("Camilla", domicilio1, televisor1);

                //Console.WriteLine(televisor1);
                //Console.WriteLine(domicilio1);
                //Console.WriteLine(persona1);
                //Console.WriteLine(persona2);

                Console.WriteLine("-------------------------- TESTS ------------------------------");
                Console.WriteLine();
                Console.WriteLine("-------------------------- DATOS ------------------------------");
                Console.WriteLine();
                Console.WriteLine("1) Datos del televisor1");
                Console.WriteLine(televisor1);
                Console.WriteLine();
                Console.WriteLine("2) Datos del domicilio1");
                Console.WriteLine(domicilio1);
                Console.WriteLine();
                Console.WriteLine("3) Datos de persona1");
                Console.WriteLine(persona1);
                Console.WriteLine();
                Console.WriteLine("4) Datos de persona2");
                Console.WriteLine(persona2);

                Console.WriteLine();
                Console.WriteLine("------------------------ MÉTODOS ------------------------------");
                Console.WriteLine();
                Console.WriteLine("1) Ver el estado del televisor");
                Console.WriteLine("El televisor se encuentra encendido? " + persona1.Tele.verPrendido());

                Console.WriteLine();
                Console.WriteLine("2) Cambiar el estado");
                persona1.Tele.cambiarEstado();
                Console.WriteLine("El televisor se encuentra encendido? " + persona1.Tele.verPrendido());


                Console.WriteLine();
                Console.WriteLine("3) Verificar canal de televisor");
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());

                Console.WriteLine();
                Console.WriteLine("4) Cambiar de a un canal");
                televisor1.cambiarCanal();
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());

                //Console.WriteLine();
                //Console.WriteLine("5) Cambiar de a un canal");
                //persona1.Tele.cambiarEstado();
                //Console.WriteLine("El televisor se encuentra encendido? " + persona1.Tele.verPrendido());

                Console.WriteLine();
                Console.WriteLine("5) Cambiar al canal 15");
                televisor1.cambiarCanal(15);
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());

                Console.WriteLine();
                Console.WriteLine("6) Cambiar al canal 150");
                televisor1.cambiarCanal(150);
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());

                Console.WriteLine();
                Console.WriteLine("7) Intentar cambiar pasar a un canal más allá de 150, de a uno");
                televisor1.cambiarCanal();
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());

                Console.WriteLine();
                Console.WriteLine("8) Intentar cambiar pasar a un canal más allá de 150");
                televisor1.cambiarCanal(151);
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());

                Console.WriteLine();
                Console.WriteLine("9) Cambiar el estado del televisor desde el usuario");
                persona1.Tele.cambiarEstado();
                Console.WriteLine("El televisor se encuentra encendido? " + persona1.Tele.verPrendido());

                Console.WriteLine();
                Console.WriteLine("10) Manejo de error cuando el televisor esta apagaado y se intenta obtener el canal");
                Console.WriteLine("El televisor esta en el canal: " + televisor1.obtenerCanalActual());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
