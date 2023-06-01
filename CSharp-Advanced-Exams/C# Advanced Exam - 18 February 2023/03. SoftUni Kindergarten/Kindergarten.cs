using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Child> Registry { get; set; }

        public int ChildrenCount { get { return Registry.Count; } }


        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveChild(string childFullName)
        {
            string[] fullName = childFullName.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            string firstName = fullName[0];
            string lastName = fullName[1];
            if (Registry.Any(c => c.FirstName == firstName && c.LastName == lastName))
            {
                int index = Registry.FindIndex(c => c.FirstName == firstName && c.LastName == lastName);
                Registry.RemoveAt(index);
                return true;
            }
            else
            {
                return false;  
            }
        }

        public Child GetChild(string childFullName)
        {
            string[] fullName = childFullName.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
            string firstName = fullName[0];
            string lastName = fullName[1];
            if (Registry.Any(c => c.FirstName == firstName && c.LastName == lastName))
            {
                Child neededChild = Registry
                    .Where(c => c.FirstName == firstName && c.LastName == lastName)
                    .Select(c => c).Select(c => c).FirstOrDefault();
                return neededChild;
            }
            else
            {
                return null;
            }
        }

        public string RegistryReport()
        {
            StringBuilder result = new();
            result.AppendLine($"Registered children in {Name}:");
            foreach (var child in Registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                result.AppendLine(child.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
