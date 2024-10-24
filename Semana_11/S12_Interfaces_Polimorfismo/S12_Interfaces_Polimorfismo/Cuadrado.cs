using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_Interfaces_Polimorfismo
{
    internal class Cuadrado : IAreaCalculable
    {
        public double Lado;

        public Cuadrado(double Lado)
        {
            this.Lado = Lado;
        }

        public double CalcularArea() 
        {
            return Math.Pow(Lado,2);
        }
    }
}
