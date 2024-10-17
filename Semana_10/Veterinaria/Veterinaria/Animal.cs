using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    abstract class Animal
    {
        private string nombre;

        public Animal(string n)
        {
            nombre = n;
        }

        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public abstract void hacerSonido();
        public abstract void caminar();
        public void comer()
        {
            Console.WriteLine(nombre + ": comiendo... ");
        }
    }
}
