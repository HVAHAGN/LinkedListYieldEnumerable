using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_07
{
   static class MicMath
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            return sum;
        }
        public static int Sum(ListNode listNode)
        {
            int sum = 0;
            foreach (int item in listNode)
            {
                sum += item;
            }
            return sum;
        }
    }
}
