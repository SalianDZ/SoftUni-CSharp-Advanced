using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new();
        }

        public int Count { get { return list.Count; } }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T removedElement = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return removedElement;
        }
    }
}