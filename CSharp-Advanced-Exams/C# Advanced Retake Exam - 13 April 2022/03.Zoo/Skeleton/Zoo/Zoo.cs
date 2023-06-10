using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals { get; private set; }

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public string AddAnimal(Animal animal)
        {
            if (Animals.Count < Capacity)
            {
                if (animal.Species == null || animal.Species == " ")
                {
                    return "Invalid animal species.";
                }

                if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }

                Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
            else
            {
                return "The zoo is full.";
            }
        }

        public int RemoveAnimals(string species)
        {
            int count = Animals.Count(x => x.Species == species);
            Animals.RemoveAll(x => x.Species == species);
            return count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> result = Animals.Where(x => x.Diet == diet).ToList();
            return result;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal animal = Animals.Where(x => x.Weight == weight).FirstOrDefault();
            return animal;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = Animals.Count(x => x.Length >= minimumLength && x.Length <= maximumLength);
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
