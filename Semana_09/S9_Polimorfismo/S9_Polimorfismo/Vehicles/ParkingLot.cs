using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S9_Polimorfismo.Vehicles
{
    internal class ParkingLot
    {
        public String name { get; private set; }

        public ParkingLot(string name)
        {
            this.name = name;
        }

        public virtual void park(Vehicle vehicle) => Console.WriteLine($"Vehicle Model: {vehicle.model} => Parked Vehicle!");
    }
}
