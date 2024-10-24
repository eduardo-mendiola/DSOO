using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_Interfaces_Polimorfismo
{
    internal class CirculoInformacion : Circulo, IInformacionFigura
    {
        public double Area { get; private set; }

        public CirculoInformacion(double Radio) : base(Radio)
        {
        }

        public void ObtenerInformacion()
        {
            Area = Math.Round(CalcularArea(), 3);
            Console.WriteLine($"El área de un círculo de radio {Radio} cm, es igual a {Area} cm2");
        }
    }
}
