using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Queues
{
    [TestFixture]
    class QueueTest
    {
        Queue<int> myQueue = new Queue<int>();

        [Test]
        public void EnqueueTest()
        {
            myQueue.Clear();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            Assert.That(myQueue.Size == 3);
        }

        [Test]
        public void DequeueTest()
        {
            myQueue.Clear();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            myQueue.Dequeue();

            Assert.That(myQueue.Size == 2);

            myQueue.Dequeue();

            Assert.That(myQueue.Size == 1);

            myQueue.Dequeue();

            Assert.That(myQueue.Size == 0);
        }

        [Test]
        public void PeekTest()
        {
            myQueue.Clear();

            myQueue.Enqueue(1);

            int testNode = myQueue.Peek();

            Assert.That(testNode == 1);
        }
    }
}
