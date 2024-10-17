using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Perro : Vertebrado
    {
        public Perro(string n) : base(n) { }

        public override void hacerSonido()
        {
            Console.WriteLine(Nombre + ": GUAU!");
        }

        public void darLaPatita()
        {
            Console.WriteLine(Nombre + ": Dando la patita!");
        }
    }
}
