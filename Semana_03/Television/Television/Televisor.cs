using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Television
{
    internal class Televisor
    {
        private String marca;
        private String modelo;
        private int pulgadas;
        private bool estado = false;
        private int numCanal = 0;

        public Televisor(string marca, string modelo, int pulgadas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.pulgadas = pulgadas;

        }

        public string Marca { get => marca; private set => marca = value; }
        public string Modelo { get => modelo; private set => modelo = value; }
        public int Pulgadas { get => pulgadas; private set => pulgadas = value; }
        public bool Estado { get => estado; private set => estado = value; }
        public int NumCanal { get => numCanal; private set => numCanal = value; }

        public override string ToString()
        {
            //return $"Marca: {Marca}, Modelo: {Modelo}, Pulgadas: {Pulgadas}, Estado: {Estado}, Número de canal: {NumCanal}"; 

            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            string result = "";

            foreach (var prop in properties)
            {
                result += $"{prop.Name}: {prop.GetValue(this, null)}\n";
            }

            return result;
        }




        // Devuelve un valor entero con el número de canal que esta visualizándose en ese momento.
        public int obtenerCanalActual() { 
            if (estado)
            {
                return numCanal;
            }
            else
            {
                throw new InvalidOperationException("No es posible acceder al canal, el televisor está apagado.");
            }
        }

        // Cambia el canal al número de canal que reciba por parámetro.
        public void cambiarCanal(int canal)
        {
            if (estado)
            {
                if (canal > 150)
                {
                    numCanal = 150;
                }
                else if (canal < 0)
                {
                    numCanal = 0;
                }
                else { numCanal = canal; }
            }
            else 
            {
                throw new InvalidOperationException("No se puese cambiar de canal, el televisor está apagado.");
            }


        }

        // Cambia el canal incrementando en uno al que se está reproduciendo actualmente.
        // Si llega al tope de 150, debe comenzar por el primero.
        public void cambiarCanal()
        {
            if (estado)
            {
                if (numCanal >= 150)
                {
                    numCanal = 0;
                }
                else
                {
                    numCanal += 1;
                }
            } 
            else 
            {
                throw new InvalidOperationException("No se puese cambiar de canal, el televisor está apagado.");
            }
        }

        // Informa con un verdadero si el televisor está encendido o falso en caso contrario.
        public bool verPrendido()
        {
            return estado;
        }

        // Si el televisor se encontraba encendido entonces se debe apagar, y viceversa.
        public void cambiarEstado()
        {
            if (!estado)
            {
                estado = true;
            } else { 
                estado = false; 
            }
        }


    }
}
