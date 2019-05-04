using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace LinkedList_09
{
    class ListNode<T>:IEnumerable<T>
    {
        public T value;
        public ListNode<T> next;
        private ListNode<T> _currentNode;
        public ListNode(T item)
        {
            value = item;
        }
        public void Add(T item)
        {
            if(_currentNode==null)
            {
                next = new ListNode<T>(item);
                _currentNode = next;
            }
            else
            {
                _currentNode.next = new ListNode<T>(item);
                _currentNode = _currentNode.next;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this;
            while (node != null)
            {
                yield return node.value;
                node = node.next;
            }

        }

       IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
