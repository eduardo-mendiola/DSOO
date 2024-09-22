using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    internal class SuperHeroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int poderes;

        public SuperHeroe(string nombre, int fuerza, int resistenci, int poderes)
        {
            this.nombre = nombre;
            this.fuerza = fuerza;
            this.resistencia = resistenci;
            this.poderes = poderes;
        }

        public string Nombre { get => nombre; private set => nombre = value; }
        public int Fuerza { get => fuerza; private set => fuerza = evaluarRango(value); }
        public int Resistenci { get => resistencia; private set => resistencia = evaluarRango(value); }
        public int Poderes { get => poderes; private set => poderes = evaluarRango(value); }

        private int evaluarRango(int valor)
        {
            if (valor < 0)
            {
                return 0;
            }
            else if (valor > 100)
            {
                return 100;
            }
            else
            {
                return valor;
            }
        }

        public void competir(SuperHeroe otroSuperHeroe)
        {
            int puntosThis = 0;
            int puntosOther = 0;
            if (this.fuerza > otroSuperHeroe.fuerza)
            {
                puntosThis++;
            }
            else
            {
                puntosOther++;
            }

            if (this.resistencia > otroSuperHeroe.resistencia)
            {
                puntosThis++;
            }
            else
            {
                puntosOther++;
            }
            if (this.poderes > otroSuperHeroe.poderes)
            {
                puntosThis++;
            }
            else
            {
                puntosOther++;
            }

            if (puntosThis > puntosOther)
            {
                Console.WriteLine("TRIUNFO");
            }
            else if (puntosThis < puntosOther)
            {
                Console.WriteLine("DERROTA");
            }
            else { Console.WriteLine("EMPATE"); }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

