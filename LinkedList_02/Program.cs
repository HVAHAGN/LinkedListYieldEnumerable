using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode
            {
                value = 10,
                next = new ListNode
                {
                    value = 20,
                    next = new ListNode
                    {
                        value = 30,
                        next = new ListNode
                        {
                            value = 40,
                            next = new ListNode
                            {
                                value = 50,
                                next = null
                            }
                        }
                    }
                }

            };







            Console.ReadLine();
        }
    }
}
