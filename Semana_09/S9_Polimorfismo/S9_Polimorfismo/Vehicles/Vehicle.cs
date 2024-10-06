using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S9_Polimorfismo.Vehicles
{
    internal class Vehicle
    {
        public String model {  get; private set; }

        public Vehicle(String model) 
        {
            this.model = model;
        }
    }
}
