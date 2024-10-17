﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Leon : Vertebrado
    {
        public Leon(string n) : base(n) { }
        public override void hacerSonido()
        {
            Console.WriteLine(Nombre + ": GRRRRR");
        }
    }
}
