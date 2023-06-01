using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public List<Cloth> Clothes { get; set; }


        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            if (Clothes.Any(x => x.Color == color))
            {
                int indexOfWantedCloth = Clothes.FindIndex(x => x.Color == color);
                Clothes.RemoveAt(indexOfWantedCloth);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Cloth GetSmallestCloth()
        {
            List<Cloth> orderedClothes = Clothes;
            orderedClothes = orderedClothes.OrderByDescending(x => x.Size).ToList();
            Cloth wantedCloth = orderedClothes[orderedClothes.Count - 1];
            return wantedCloth;
        }

        public Cloth GetCloth(string color)
        {
            int indexOfWantedCloth = Clothes.FindIndex(x => x.Color == color);
            return Clothes[indexOfWantedCloth];
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            StringBuilder result = new();
            result.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in Clothes.OrderBy(x => x.Size))
            {
                result.AppendLine($"{cloth}");
            }
            return result.ToString().TrimEnd();
        }
    }
}
