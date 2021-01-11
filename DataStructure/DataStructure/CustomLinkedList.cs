using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomLinkedList<T>
    {
        private Node<T> head;

        public void Insert(T value)
        {
            var node = new Node<T>(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }
        }

        public IEnumerable<T> Traverse()
        {
            Node<T> current = head;
            while (current != null)
            {
                var tmp = current.CurrentValue;
                current = current.Next;
                yield return tmp;
            }
        }
    }

    public class Node<T>
    {
        private T currentValue;

        public Node()
        {
            currentValue = default(T);
        }

        public Node(T value)
        {
            currentValue = value;
        }

        public Node<T> Next { get; set; }

        public T CurrentValue => currentValue;
    }
}
