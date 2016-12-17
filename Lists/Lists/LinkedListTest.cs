using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lists
{
    [TestFixture]
    public class LinkedListTest
    {
        LinkedList<int> testList = new LinkedList<int>();

        [Test]
        public void EmptyTest()
        {
            Assert.IsTrue(testList.IsEmpty());
        }

        [Test]
        public void InsertBeginningTest()
        {
            var testNode = new Node<int>(1);
            testList.InsertBeginning(testNode);

            Assert.That(testList.head.Content == 1);
        }

        [Test]
        public void InsertBeginningTestTwo()
        {
            testList.InsertBeginning(10);
            Assert.IsTrue(testList.head.Content == 10);
        }

        [Test]
        public void RemoveBeginningTest()
        {
            while(testList.IsEmpty() == false)
            {
                testList.RemoveBeginning();
            }
            Assert.IsTrue(testList.IsEmpty());
            Assert.That(testList.head == null);
        }

        [Test]
        public void InsertAfterTest()
        {
            var firstNode = new Node<int>(1);
            var secondNode = new Node<int>(2);
            var thirdNode = new Node<int>(3);

            testList.InsertBeginning(firstNode);
            testList.InsertAfter(firstNode, secondNode);
            testList.InsertAfter(secondNode, thirdNode);

            Assert.That(testList.head == firstNode);
            Assert.That(testList.head.Next == secondNode);
            Assert.That(testList.head.Next.Next == thirdNode);
        }

        [Test]
        public void RemoveAfterTest()
        {
            testList.Clear();

            var fourthNode = new Node<int>(4);
            var fifthNode = new Node<int>(5);

            testList.InsertBeginning(fourthNode);
            testList.InsertAfter(fourthNode, fifthNode);

            Assert.That(testList.Length() == 2);
            Assert.That(testList.head.Content == 4 && testList.head.Next.Content == 5);

            testList.RemoveAfter(fourthNode);

            Assert.That(testList.head.Next == null);
            Assert.That(testList.Length() == 1);
            Assert.That(testList.head.Content == 4);
        }
    }
}
