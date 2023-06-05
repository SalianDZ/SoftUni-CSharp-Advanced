using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class CustomThreeuple<T1, T2, T3>
    {
        public CustomThreeuple(T1 firstItem, T2 secondItem, T3 thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public T1 FirstItem { get; private set; }

        public T2 SecondItem { get; private set; }

        public T3 ThirdItem { get; private set; }

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
