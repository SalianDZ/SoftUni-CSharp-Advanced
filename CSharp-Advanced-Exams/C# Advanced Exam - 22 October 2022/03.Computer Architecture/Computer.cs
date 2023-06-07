using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new();
        }

        public string Model { get; set; }

        public int Capacity { get; set; }

        public List<CPU> Multiprocessor { get; private set; }

        public int Count { get { return Multiprocessor.Count; } }

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            if (Multiprocessor.Any(c => c.Brand == brand))
            {
                CPU cpu = Multiprocessor.Where(x => x.Brand == brand).FirstOrDefault();
                Multiprocessor.Remove(cpu);
                return true;
            }
            else
            {
                return false;
            }
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(c => c.Frequency).FirstOrDefault();
        }

        public CPU GetCPU(string brand)
        {
            if (true)
            {
                CPU cpu = Multiprocessor.Where(x => x.Brand == brand).FirstOrDefault();
                return cpu;
            }
            else
            {
                return null;
            }
        }

        public string Report()
        {
            StringBuilder result = new();
            result.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var cpu in Multiprocessor)
            {
                result.AppendLine(cpu.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
