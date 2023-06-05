using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfInteger
{
    public class Box<T>
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
    }
}
