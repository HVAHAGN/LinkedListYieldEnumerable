using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_09
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode<int> listNode = new ListNode<int>(10) { 20, 30, 40, 50, 60, 70 };

            int[] arr = listNode.ToArray();
            Console.ReadLine();
        }
    }
}
