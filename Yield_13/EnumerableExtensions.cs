using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_13
{
    static class EnumerableExtensions
    {
        public static List<int> EvenNumbers(this List<int> source)
        {
            List<int> items = new List<int>();
            foreach (var item in source)
            {
                if (item % 2 == 0)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        public static List<int> GreaterThan(this List<int> source, int number)
        {
            List<int> items = new List<int>();
            foreach (var item in source)
            {
                if (item > number)
                    items.Add(item);
            }
            return items;
        }

    }
}
