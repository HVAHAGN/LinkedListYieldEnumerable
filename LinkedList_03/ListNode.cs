using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_03
{
    class ListNode
    {
        public int value;
        public ListNode(int item)
        {
            value = item;
        }
        public ListNode next;


        public ListNode Add(int item)
        {
            next = new ListNode(item);
            return next;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
