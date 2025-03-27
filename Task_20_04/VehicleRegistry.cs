namespace Task_20_04
{
    public class VehicleRegistry
    {
        private List<VehicleType> vehicles = new List<VehicleType>();

        public void AddVehicle(VehicleType vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine($"Добавлено транспортное средство: {vehicle}");
        }

        public int CountVehicles(VehicleType vehicleType)
        {
            return vehicles.Count(v => v == vehicleType);
        }

        public void ShowVehicles(VehicleType vehicleType)
        {
            var foundVehicles = vehicles.Where(v => v == vehicleType).ToList();
            if (foundVehicles.Any())
            {
                Console.WriteLine($"Транспортные средства типа {vehicleType}:");
                foreach (var vehicle in foundVehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine($"Нет транспортных средств типа {vehicleType}.");
            }
        }
    }
}
