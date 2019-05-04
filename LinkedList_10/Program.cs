using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_10ICollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode<string> listString = new ListNode<string>("Samo");
            listString.Add("Alice");
            listString.Add("Bob");
            listString.Add("Sam");
            listString.Add("Armen");
            listString.Add("Norik");

            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
            listString.Add("2565");
            listString.Remove("Sam");
            Console.WriteLine("After removing Sam");
            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }

            ListNode<int> listNum = new ListNode<int>(15);
            listNum.Add(50);
            listNum.Add(5580);
            listNum.Add(5250);
            listNum.Add(5260);
            listNum.Add(5150);
            foreach (var item in listNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(listNum.Contains(51550));
            Console.ReadLine();
        }
    }
}
