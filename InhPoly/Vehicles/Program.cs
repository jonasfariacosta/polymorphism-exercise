using Vehicles.Classes;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car carA = new Car("Ford", "XR2");
            Motorcycle motorcycleA = new Motorcycle("Yamaha", "japanese", false);

            carA.StartEngine();
            Console.WriteLine("car is running");

            motorcycleA.StartEngine();
            Console.WriteLine("motorcycle is running");

            carA.Drive();
            motorcycleA.Drive();



        }
    }
}
