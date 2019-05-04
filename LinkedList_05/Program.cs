using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_05
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode root = new ListNode(10);
            root.Add(20);
            root.Add(500);
            root.Add(1650);
            root.Add(30);
            int max = root.value;
            ListNode node = root.next;

            while (node != null)
            {
                if (node.value > max)

                    max = node.value;
                node = node.next;
            }

            Console.WriteLine($"In the current list max value is {max}");
            Console.ReadLine();
        }
    }
}
