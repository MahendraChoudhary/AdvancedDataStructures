using System.Collections.Generic;

namespace DataStructure
{
    public interface ICustomLinkedList<T>
    {
        void Insert(T value);
        IEnumerable<T> Traverse();
    }
}