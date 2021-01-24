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
            
            var current = Root;
            var parent = current;
            int compare = 0;
            while (current != null)
            {
                parent = current;
                compare = current.Value.CompareTo(value);
                current = compare < 0 ? current.Right : current.Left;
            }

            if (parent != null)
            {
                if (compare < 0)
                {
                    parent.Right = node;
                }
                else
                {
                    parent.Left = node;
                }
            }
            else
            {
                Root = node;
            }

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
