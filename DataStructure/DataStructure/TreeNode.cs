using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class TreeNode<T>
        where T : IComparable<T>
    {
        public TreeNode(T value)
        {
            this.Value = value;
        }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public T Value { get; }
    }
}
