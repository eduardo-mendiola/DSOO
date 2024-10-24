using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_Interfaces_Polimorfismo
{
    internal class CuadradoInformacion : Cuadrado, IInformacionFigura
    {
        public double Area { get; private set; }
        public CuadradoInformacion(double Lado) : base(Lado)
        {
        }

        public void ObtenerInformacion()
        {
            Area = CalcularArea();
            Console.WriteLine($"El área de un cuadrado de lado {Lado} cm, es igual a {Area} cm2");
        }
    }
}
