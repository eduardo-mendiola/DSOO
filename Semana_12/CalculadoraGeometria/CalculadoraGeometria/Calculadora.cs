using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraGeometria
{
    internal class Calculadora
    {
        public static double Base;
        public static double Altura;
        public static double Radio;

        public static double AreaRectangulo()
        {
            return (Base * Altura);
        }

        public static double PerimetroRectangulo()
        {
            return ((2 * Base) + (2 * Altura));
        }

        public static double AreaCirculo()
        {
            return (Math.PI * Math.Pow(Radio, 2));
        }

        public static double PerimetroCirculo()
        {
            return (2 * Math.PI * Radio);
        }
    }
}
