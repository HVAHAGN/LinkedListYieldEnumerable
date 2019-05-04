using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            List<int> list = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            ListNode listNode = new ListNode(10) { 20, 30, 40, 50, 60, 70, 80, 90 };

            int sum = MicMath.Sum(arr);
            int sum2 = MicMath.Sum(list);
            int sum3 = MicMath.Sum(listNode);
            Console.WriteLine($"{sum}***{sum2}***{sum3}");

            ListNode listNode2 = new ListNode(10);
            listNode2.Add(20);
            listNode2.Add(30);
            listNode2.Add(40);
            listNode2.Add(50);
            IEnumerator enumerator = listNode2.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int item = (int)enumerator.Current;
                Console.WriteLine(item);
            }

            enumerator.Reset();


            Console.ReadLine();
        }
    }
}
