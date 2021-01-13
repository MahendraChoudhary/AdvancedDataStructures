using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class CustomStackTests
    {
        [TestMethod]
        public void PushData()
        {
            var stack = new CustomStack<int>();
            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }
        }

        [TestMethod]
        public void PopData()
        {
            var stack = new CustomStack<int>();
            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }

            for (int i = 99; i >= 0 ; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }

        [TestMethod]
        public void PeekData()
        {
            var stack = new CustomStack<int>();
            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }

            for (int i = 99; i >= 1; i--)
            {
                Assert.AreEqual(i, stack.Peek());
                Assert.AreEqual(i, stack.Pop());
                Assert.AreEqual(i-1, stack.Peek());
            }
        }
    }
}
