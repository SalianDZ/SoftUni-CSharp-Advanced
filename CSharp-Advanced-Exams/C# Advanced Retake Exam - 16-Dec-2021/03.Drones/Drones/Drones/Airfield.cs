using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }

        public List<Drone> Drones { get; private set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public double LandingStrip  { get; set; }

        public int Count { get { return Drones.Count; } }


        public string AddDrone(Drone drone)
        {
            if (Drones.Count <= Capacity)
            {
                if (drone.Name == string.Empty)
                {
                    return "Invalid drone.";
                }

                if (drone.Name == " ")
                {
                    return "Invalid drone.";
                }

                if (drone.Name == "")
                {
                    return "Invalid drone.";
                }

                if (drone.Brand == string.Empty)
                {
                    return "Invalid drone.";
                }

                if (drone.Brand == " ")
                {
                    return "Invalid drone.";
                }

                if (drone.Brand == "")
                {
                    return "Invalid drone.";
                }

                if (drone.Range < 5 || drone.Range > 15)
                {
                    return "Invalid drone.";
                }

                Drones.Add(drone);
                Capacity--;
                return $"Successfully added {drone.Name} to the airfield.";
            }
            else
            {
                return "Airfield is full.";
            }
        }

        public bool RemoveDrone(string name)
        {
            if (Drones.Any(x => x.Name == name))
            {
                Drone drone = Drones.FirstOrDefault(x => x.Name == name);
                Drones.Remove(drone);
                Capacity++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemoveDroneByBrand(string brand)
        {
            if (Drones.Any(x => x.Brand == brand))
            {
                int count = Drones.Count(x => x.Brand == brand);
                Capacity += count;
                Drones.RemoveAll(x => x.Brand == brand);
                return count;
            }
            else
            {
                return 0;
            }
        }

        public Drone FlyDrone(string name)
        {
            if (Drones.Any(x => x.Name == name))
            {
                Drone drone = Drones.FirstOrDefault(x => x.Name == name);
                drone.Available = false;
                return drone;
            }
            else
            {
                return null;
            }
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> result = Drones.Where(x => x.Range >= range).ToList();
            foreach (var drone in result)
            {
                drone.Available = false;
            }
            return result;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Drones available at {Name}:");
            foreach (var drone in Drones.Where(x => x.Available == true))
            {
                result.AppendLine(drone.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
