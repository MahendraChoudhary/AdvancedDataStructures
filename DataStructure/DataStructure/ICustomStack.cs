namespace DataStructure
{
    public interface ICustomStack<T>
    {
        T Peek();
        T Pop();
        void Push(T item);
    }
}