using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinarySearchTree<T>
        where T : IComparable<T>
    {
        public BinarySearchTree()
        {
        }

        public TreeNode<T> Root { get; private set; }

        public void Insert(T value)
        {
            var node = new TreeNode<T>(value);
            if (Root == null)
            {
                Root = node;
                return;
            }
            var current = Root;
            var parent = current;
            while (current != null)
            {
                parent = current;
                if (value.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = node;
                        return;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = node;
                        return;
                    }
                }
            }

        }

        public bool BFS(T value)
        {
            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(Root);
            while (nodes.Count != 0)
            {
                var presentNode = nodes.Dequeue();
                int compare = presentNode.Value.CompareTo(value);
                if (compare == 0)
                {
                    return true;
                }

                if (presentNode.Left != null)
                {
                    nodes.Enqueue(presentNode.Left);
                }
                if (presentNode.Right != null)
                {
                    nodes.Enqueue(presentNode.Right);
                }

            }
            return false;
        }

        public void Inorder(TreeNode<T> root)
        {
            if (root != null)
            {
                Debug.Write(root.Value + " ");
                Inorder(root.Left);
                Console.WriteLine(root.Value + " ");
                Inorder(root.Right);
            }
        }
    }
}
