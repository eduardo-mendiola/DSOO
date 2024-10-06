using S9_Polimorfismo.Animals;
using S9_Polimorfismo.Vehicles;

namespace S9_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Animal cow = new Cow();

            dog.MakeSound();
            cat.MakeSound();
            cow.MakeSound();

            Console.WriteLine("\n---------------------------------------\n");

            Vehicle[] myVehicles = new Vehicle[6];
            myVehicles[0] = new Vehicle("Generico");
            myVehicles[1] = new Car("Fiat Palio");
            myVehicles[2] = new Motorcycle("Yamaha YBR");
            myVehicles[3] = new Pickup("VW Amarok");
            myVehicles[4] = new Taxi("VW Suran Taxi");
            myVehicles[5] = new Bus("Mercedes Benz");
            ParkingLot parking = new ParkingLot("My ParkingLot");
            foreach (Vehicle v in myVehicles)
            {
                parking.park(v);
            }




        }
    }
}
