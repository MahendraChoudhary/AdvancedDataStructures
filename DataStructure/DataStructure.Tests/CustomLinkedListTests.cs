using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class CustomLinkedListTests
    {
        [TestMethod]
        public void InsertData()
        {
            var linkList = new CustomLinkedList<int>();
            for (int i = 0; i < 100; i++)
            {
                linkList.Insert(i);
            }

            var items = linkList.Traverse();
            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(i, items.ElementAt(i));
            }
        }
    }
}
