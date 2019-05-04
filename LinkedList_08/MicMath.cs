using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_08
{
    static class MicMath
    {
        public static int Sum(IEnumerable source)
        {
            int sum = 0;
            foreach (int item in source)
            {
                sum += item;
            }
            return sum;
        }
    }
}
