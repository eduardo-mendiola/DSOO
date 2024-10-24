using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_Interfaces_Polimorfismo
{
    internal class Circulo : IAreaCalculable
    {
        public double Radio {  get; private set; }
        public Circulo(double Radio) 
        {
            this.Radio = Radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
