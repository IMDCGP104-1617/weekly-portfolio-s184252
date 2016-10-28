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
            // testing functions
            DoublyLinkedList myDoubleList = new DoublyLinkedList();
            myDoubleList.InsertBeginning(17);
            myDoubleList.InsertBeginning(23);
            for(int i = 0; i < 50; i++)
            {
                myDoubleList.AppendNode(i);
            }
            DoublyLinkedList.Node myNode = new DoublyLinkedList.Node();
            myNode.Content = 171717;
            myDoubleList.AppendNode(myNode);
            myDoubleList.AppendNode(new DoublyLinkedList.Node(441));

            LinkedList myLinkedListX = new LinkedList();
            LinkedList myLinkedListY = new LinkedList();

            myLinkedListX.AppendNode(12);
            myLinkedListX.InsertBeginning(21);

            for(int i = 0; i < 50; i++)
            {
                myLinkedListY.AppendNode(i);
            }

            myDoubleList.AppendNode(myLinkedListX);
            myDoubleList.AppendNode(myLinkedListY);
            myDoubleList.PrintNodes();
            System.Console.ReadLine();
        }
    }
}
