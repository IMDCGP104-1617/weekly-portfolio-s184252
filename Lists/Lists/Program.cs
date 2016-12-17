using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing doublylinkedlist, all tests can be found in nunit test classes
            DoublyLinkedList<int> myList = new DoublyLinkedList<int>();

            var firstNode = new Node<int>(1);
            var secondNode = new Node<int>(2);
            var thirdNode = new Node<int>(3);

            myList.InsertBeginning(firstNode);

            Console.WriteLine("Size after firstNode: " + myList.Size);

            myList.InsertAfter(firstNode, secondNode);

            Console.WriteLine("Size after secondNode: " + myList.Size);

            myList.InsertBefore(secondNode, thirdNode);

            Console.WriteLine("Size after thirdNode: " + myList.Size);

            myList.RemoveBefore(secondNode);

            Console.WriteLine("Size after removing thirdNode: " + myList.Size);

            myList.InsertAfter(secondNode, thirdNode);

            Console.WriteLine("Size after thirdNode again: " + myList.Size);

            Console.WriteLine(myList.IsEmpty().ToString());

            myList.DisplayList();

            myList.Clear();
            Console.WriteLine(myList.Size);
            Console.WriteLine(myList.IsEmpty().ToString());
            Console.ReadLine();
        }
    }
}
