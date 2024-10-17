using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    abstract class Vertebrado : Animal
    {
        public Vertebrado(string n) : base(n)
        {
        }

        public override void caminar()
        {
            Console.WriteLine(Nombre + ": caminando... ");
        }
    }
}
