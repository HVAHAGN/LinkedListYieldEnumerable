using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_08
{
    class ListNode:IEnumerable
    {
        public int value;
        public ListNode next;
        public ListNode(int item)
        {
            value = item;

        }
        private ListNode _currentNode;
        public void Add(int item)
        {
            if(_currentNode==null)
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

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        private class Enumerator : IEnumerator
        {
            private ListNode _node;
            public Enumerator(ListNode root)
            {
                _node = root;
            }

           public object Current { get; private set; }
           public bool MoveNext()
            {
                if (_node == null)
                    return false;
                Current = _node.value;
                _node = _node.next;
                return true;
            }

            public void Reset()
            {
                _node = null;
            }

        }


    }
}
