using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace S9_Polimorfismo.Animals
{
    internal class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("The animal is making a sound.");
    }
}
