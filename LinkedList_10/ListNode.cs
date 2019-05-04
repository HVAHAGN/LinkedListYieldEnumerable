using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList_10ICollection
{
    class ListNode<T> : ICollection<T>
    {

        public T value;
        public ListNode<T> next;
        private ListNode<T> head;
        private ListNode<T> tail;
        int count;
        public ListNode(T item)
        {
            value = item;

        }
        T[] elements = new T[0];
        public void Add(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            if (head == null)
            {
               head = node;
            }
            else
            {
               tail.next = node;
            }
            tail = node;
            count++;
        }

        public bool Remove(T item)
        {
            ListNode<T> current = head;
            ListNode<T> previous = null;
            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null)
                        {
                            tail = previous;
                        }
                        else
                        {
                            head = head.next;
                        }
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;


        }

        public bool Contains(T item)
        {
            ListNode<T> current = head;
            while (current != null)
            {
                if (current.value.Equals(item))
                    return true;
                current = current.next;

            }
            return false;
        }

        public void AppendFirst(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            node.next = head;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            count++;
        }

        public void AddWithoutTail(T item)
        {
            ListNode<T> node = new ListNode<T>(item);
            if (head == null)
                head = node;
            else
            {
                ListNode<T> current = head;
                while (current != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
            count++;
        }

        public override string ToString()
        {
            return value. ToString();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }



        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            ListNode<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }
       /* public class Enumerator : IEnumerator<T>
        {
            private ListNode<T> _node;
            public Enumerator(ListNode<T> root)
            {
                _node = root;
            }

            public T Current { get; private set; }
            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_node == null)
                    return false;
                else
                {
                    Current = _node.value;
                    _node = _node.next;
                    return true;
                }
            }
            public void Reset()
            {
                _node = null;
            }
            public void Dispose()
            {
                Reset();
            }
        }*/
    }
}
