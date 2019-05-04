using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 10,20,30,40,50,60,70};
            List<int> list = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };
            ListNode listNode = new ListNode(10) { 20, 30, 40, 50, 60, 70 };

            int sum1 = MicMath.Sum(arr);
            Console.WriteLine(sum1);
            int sum2 = MicMath.Sum(list);
            Console.WriteLine(sum2);
            int sum3 = MicMath.Sum(listNode);
            Console.WriteLine(sum3);


            Console.ReadLine();
        }
    }
}
