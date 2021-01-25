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

        [TestMethod]
        public void BFSTest()
        {
            var bst = new BinarySearchTree<int>();
            bst.Insert(15);
            bst.Insert(14);
            bst.Insert(13);
            bst.Insert(12);
            bst.Insert(11); 
            bst.Insert(10);
            bst.Insert(16);
            bst.Insert(17);
            bst.Insert(18);
            bst.Insert(19);
            bst.Insert(20);
            Assert.IsTrue(bst.BFS(13));
            Assert.IsTrue(bst.BFS(20));
            Assert.IsFalse(bst.BFS(21));
        }
    }
}
