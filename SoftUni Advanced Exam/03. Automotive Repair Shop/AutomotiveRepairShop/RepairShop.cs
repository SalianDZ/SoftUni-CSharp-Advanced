using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new();
        }

        public List<Vehicle> Vehicles { get; set; }
        public int Capacity { get; set; }


        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            if (Vehicles.Any(v => v.VIN == vin))
            {
                Vehicle vehicle = Vehicles.FirstOrDefault(v => v.VIN == vin);
                Vehicles.Remove(vehicle);
                return true;
            }

            return false;
        }

        public int GetCount()
        { 
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            Vehicle vehicle = Vehicles.OrderBy(x => x.Mileage).FirstOrDefault();
            return vehicle;
        }

        public string Report()
        {
            StringBuilder result = new();
            result.AppendLine("Vehicles in the preparatory:");

            foreach (var vehicle in Vehicles)
            {
                result.AppendLine(vehicle.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
