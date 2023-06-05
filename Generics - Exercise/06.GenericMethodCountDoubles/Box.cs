using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodCountDoubles
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            (items[secondIndex], items[firstIndex]) = (items[firstIndex], items[secondIndex]);
        }

        public int CompareTo(T elementToCompare)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(elementToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
