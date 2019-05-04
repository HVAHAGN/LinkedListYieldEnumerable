using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode { value = 10 };
            ListNode node2 = new ListNode { value = 20 };
            node1.next = node2;
            ListNode node3 = new ListNode { value = 30 };
            node2.next = node3;
            ListNode node4 = new ListNode { value = 40 };
            node3.next = node4;


            Console.ReadLine();
        }
    }
}
