using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_14
{
    static class EnumerableExtensions
    {
        public static IEnumerable<int> EvenNumbers(this IEnumerable<int> source)
        {
            foreach (var item in source)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }

        public static IEnumerable<int> GreaterThan(this IEnumerable<int> source, int number)
        {
            foreach (var item in source)
            {
                if (item > number)
                    yield return item;
            }
        }

    }
}
