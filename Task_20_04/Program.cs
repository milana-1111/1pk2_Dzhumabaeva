using System.Diagnostics;

namespace Task_20_04
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleRegistry registry = new VehicleRegistry();

            registry.AddVehicle(VehicleType.Car);
            registry.AddVehicle(VehicleType.Bike);
            registry.AddVehicle(VehicleType.Truck);
            registry.AddVehicle(VehicleType.Truck);
            registry.AddVehicle(VehicleType.Bus);
            registry.AddVehicle(VehicleType.Motorcycle);

            Console.WriteLine($"Количество грузовиков: {registry.CountVehicles(VehicleType.Truck)}");

            registry.ShowVehicles(VehicleType.Bus);
            registry.ShowVehicles(VehicleType.Bike);
            registry.ShowVehicles(VehicleType.Truck);
        }
    }
}
