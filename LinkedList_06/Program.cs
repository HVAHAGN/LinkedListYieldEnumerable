using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList_06
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode root = new ListNode(10);
            root.Add(20);
            root.Add(550);
            root.Add(1580);
            root.Add(770);

            IEnumerator enumerator = root.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int item = (int)enumerator.Current;
                Console.WriteLine(item);
            }

            enumerator.Reset();

            // kam
            foreach (var item in root)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
