using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(10);
            node1.Add(20)
                 .Add(30)
                 .Add(40)
                 .Add(50);

            Console.ReadLine();
        }
    }
}
