using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List <Person> members = new();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person member = new(name, age);
                members.Add(member);
            }

            //Person oldestFamilyMember = family.GetOldestMember();
            //Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
            members = members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (var person in members)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}