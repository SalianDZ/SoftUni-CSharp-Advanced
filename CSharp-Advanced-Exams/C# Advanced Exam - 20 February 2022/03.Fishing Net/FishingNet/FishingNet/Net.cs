using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            this.fish = new List<Fish>();
        }

        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;
        public string Material { get; set; }
        public int Capacity { get; set; }

        public int Count { get {return Fish.Count;} }

        public string AddFish(Fish fish)
        {
            if (Fish.Count <= Capacity)
            {
                if (fish.FishType == null)
                {
                    return "Invalid fish.";
                }
                if (fish.FishType == " ")
                {
                    return "Invalid fish.";
                }
                if (fish.FishType == "")
                {
                    return "Invalid fish.";
                }
                if (fish.Length <= 0)
                {
                    return "Invalid fish.";
                }
                if (fish.Weight <= 0)
                {
                    return "Invalid fish.";
                }
                Capacity--;
                this.fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
            else
            {
                return "Fishing net is full.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            if (Fish.Any(x => x.Weight == weight))
            {
                Fish fish = Fish.Where(x => x.Weight == weight).FirstOrDefault();
                this.fish.Remove(fish);
                Capacity++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fish GetFish(string fishType)
        {
            Fish fish = Fish.Where(x => x.FishType == fishType).FirstOrDefault();
            return fish;
        }

        public Fish GetBiggestFish()
        {
            var longestFish = this.fish.Max(e => e.Length);
            var fish = this.fish.FirstOrDefault(e => e.Length == longestFish);
            return fish;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Into the {Material}:");
            foreach (var fish in Fish.OrderByDescending(x => x.Length))
            {
                result.AppendLine(fish.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
