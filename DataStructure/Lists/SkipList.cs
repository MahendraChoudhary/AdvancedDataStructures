using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Lists
{
    public class SkipList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private Random randomizer;
        private readonly double probability=0.5;

        public SkipList()
        {
            Head = new SkipListNode<T>(default(T), 1);
            Count = 0;
            randomizer = new Random();
        }

         public SkipList(IEnumerable<T> collection) : base()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(T value)
        {
            var nodesForUpdate = new SkipListNode<T>[Height];
            var curNode = Head;

            for (int i = Height - 1; i >= 0; i--)
            {
                while (curNode[i] != null && value.CompareTo(curNode[i].Value) > 0)
                {
                    curNode = curNode[i];
                }

                nodesForUpdate[i] = curNode;
            }
            
            var nodeBeforeNodeForInsertion = nodesForUpdate[0];

            if (nodeBeforeNodeForInsertion[0] != null && value.CompareTo(nodeBeforeNodeForInsertion[0].Value) == 0)
                throw new ArgumentException("Tried to insert duplicate value!");
            
            int height = 1;
            while (randomizer.NextDouble() < probability && height < Head.Height + 1)
                height++;
            
            var newNode = new SkipListNode<T>(value, height);

            if (height > Head.Height)
            {
                Head.IncrementHeight();
                Head[Head.Height - 1] = newNode;
            }
            
            for (int i = 0; i < newNode.Height; i++)
            {
                if (i < nodesForUpdate.Length)
                {
                    newNode[i] = nodesForUpdate[i][i];
                    nodesForUpdate[i][i] = newNode;
                    
                }
            }

            Count++;
        }


        public bool Remove(T value)
        {
            if (Count == 0) return false;
            
            var nodesForUpdate = new SkipListNode<T>[Height];
            var curNode = Head;

            for (int i = Height - 1; i >= 0; i--)
            {
                while (curNode[i] != null && value.CompareTo(curNode[i].Value) > 0)
                {
                    curNode = curNode[i];
                }

                nodesForUpdate[i] = curNode;
            }

            var nodeToDelete = nodesForUpdate[0][0];

            if (nodeToDelete != null && value.CompareTo(nodeToDelete.Value) == 0)
            {
                for (int i = 0; i < Head.Height; i++)
                {
                    if (nodesForUpdate[i][i] != nodeToDelete)
                        break;
                    else
                        nodesForUpdate[i][i] = nodeToDelete[i];
                }
                
                nodeToDelete.Invalidate();
                
                if (Head[Head.Height - 1] == null)
                {
                    Head.DecrementHeight();
                }

                Count--;
                return true;
            }
            else return false;
        }

        public bool Contains(T value)
        {
            var curNode = Head;

            for (int i = Height - 1; i >= 0; i--)
            {
                while (curNode[i] != null)
                {
                    int cmp = value.CompareTo(curNode[i].Value);

                    if (cmp == 0) return true;
                    //if the value is lower that the next node we need to search on the lower level
                    if (cmp < 0) break;
                    //if the node is higher that the next node we continue comparing on the same level
                    if (cmp > 0) curNode = curNode[i];
                }
            }

            return false;
        }

        public void Clear()
        {
            var curNode = Head;
            var lastNode = Head;

            while (curNode != null)
            {
                curNode = curNode[0];
                lastNode.Invalidate();
                lastNode = curNode;
            }

            Head = new SkipListNode<T>(default(T), 1);
            Count = 0;
            randomizer = new Random();
        }

        public int Count { get; private set; }
        public SkipListNode<T> Head { get; private set; }
        public int Height => this.Head.Height;

        public IEnumerator<T> GetEnumerator()
        {
            var curNode = Head[0];

            while (curNode != null)
            {
                yield return curNode.Value;
                curNode = curNode[0];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
