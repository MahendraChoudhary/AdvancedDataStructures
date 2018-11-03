using System;

namespace DataStructure.Lists
{
    public class SkipListNode<T> where T : IComparable<T>
    {
        private SkipListNode<T>[] forwards;
        private T t;
        private int v;

        public SkipListNode<T> this[int level]
        {
            get
            {
                if (level < 0 || level >= Height) throw new IndexOutOfRangeException(nameof(level));
                return forwards[level];
            }
            internal set
            {
                if (level < 0 || level >= Height) throw new IndexOutOfRangeException(nameof(level));
                forwards[level] = value;
            }
        }

        public SkipListNode(T value, int height)
        {
            if (height < 1) throw new ArgumentOutOfRangeException(nameof(height));
            Value = value;
            forwards = new SkipListNode<T>[height];
        }
        

        public T Value { get; private set; }

        public int Height => forwards?.Length ?? 0;

        internal void IncrementHeight()
        {
            var newForwards = new SkipListNode<T>[Height + 1];
            for (int i = 0; i < Height; i++)
            {
                newForwards[i] = forwards[i];
            }

            forwards = newForwards;
        }

        internal void Invalidate()
        {
            forwards = null;
        }

        internal void DecrementHeight()
        {
            if (Height == 1) return;

            var newForwards = new SkipListNode<T>[Height - 1];
            for (int i = 0; i < Height - 1; i++)
            {
                newForwards[i] = forwards[i];
            }

            forwards = newForwards;
        }
    }
}