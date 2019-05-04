﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_05
{
    class ListNode
    {
        public int value;
        public ListNode next;
        private ListNode _currentNode;
        public ListNode(int item)
        {
            value = item;
        }

        public void Add(int item)
        {
            if (_currentNode == null)
            {
                next = new ListNode(item);
                _currentNode = next;
            }
            else
            {
                _currentNode.next = new ListNode(item);
                _currentNode = _currentNode.next;
            }
        }
        public override string ToString()
        {
            return value.ToString();
        }

    }
}
