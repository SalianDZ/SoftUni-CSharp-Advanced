using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class CustomTuple<T1, T2>
    {
        public CustomTuple(T1 firstItem, T2 secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }

        public T1 FirstItem { get; private set; }

        public T2 SecondItem { get; private set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}
