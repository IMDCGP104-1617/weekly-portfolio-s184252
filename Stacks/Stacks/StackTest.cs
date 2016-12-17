using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Stacks
{
    [TestFixture]
    class StackTest
    {
        Stack<int> myStack = new Stack<int>();

        [Test]
        public void PushTest()
        {
            myStack.Push(1);

            Assert.That(myStack.top.Content == 1);
        }

        [Test]
        public void PopTest()
        {
            myStack.Pop();

            Assert.That(myStack.IsEmpty() == true);
        }

        [Test]
        public void PeekTest()
        {
            myStack.Push(1);

            int node = myStack.Peek();

            Assert.That(node == 1);
        }
    }
}
