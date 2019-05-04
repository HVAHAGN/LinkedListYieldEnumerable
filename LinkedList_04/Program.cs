using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_04
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode node = new ListNode(10);
            for (int value = 0; value < 60; value+=10)
            {
                node.Add(value);
            }



            Console.ReadLine();

        }
       
    }
}
