using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void PushData()
        {
            var bst = new BinarySearchTree<int>();
            var rn = new Random(1);
            for (int i = 0; i < 100; i++)
            {
                if (i == 0)
                {
                    bst.Insert(50);
                    continue;
                }

                bst.Insert(rn.Next(1, 100));
            }

            bst.Inorder(bst.Root);
        }
    }
}
