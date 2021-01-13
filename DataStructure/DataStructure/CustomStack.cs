using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomStack<T> : ICustomStack<T>
    {
        T[] items;
        int size = 5, top = 0;

        public CustomStack()
        {
            items = new T[size];
        }
        public void Push(T item)
        {
            if (top == size)
            {
                var temp = items;
                items = new T[temp.Length + temp.Length / 2];
                size = items.Length;
                temp.CopyTo(items, 0);
            }

            items[top] = item;
            top++;
        }

        public T Pop()
        {
            top--;
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top];
        }

        public T Peek()
        {
            if(top==-1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top - 1];
        }
    }
}
