using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class DoublyLinkedList
    {
        public class Node
        {
            public object Content;
            public Node Previous;
            public Node Next;

            public Node(object content = null)
            {
                Content = content;
            }
        }

        private Node head;

        public DoublyLinkedList()
        {
            head = null;
        }

        // insert functions
        public void InsertBeginning(object content)
        {
            Node newNode = new Node();
            newNode.Content = content;

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node tempNode = head;
                newNode.Next = tempNode;
                tempNode.Previous = newNode;
                head = newNode;
            }
        }
        public void InsertBefore(Node before, object content)
        {
            Node current = head;
            while(current != before)
            {
                current = current.Next;
                if(current == null)
                {
                    break;
                }
            }

            if(current == null)
            {
                System.Console.WriteLine("Node: " + before + " does not exist.");
                return;
            }
            else
            {
                current = current.Previous;
                Node newNode = new Node();
                Node tempNode = current.Next;

                newNode.Content = content;
                newNode.Previous = current;
                newNode.Next = tempNode;

                tempNode.Previous = newNode;
                current.Next = newNode;
            }
        }
        public void InsertAfter(Node after, object content)
        {
            Node current = head;
            while(current != after)
            {
                current = current.Next;
                if(current == null)
                {
                    break;
                }
            }

            if(current == null)
            {
                System.Console.WriteLine("Node: " + after + " does not exist.");
                return;
            }
            else
            {
                Node newNode = new Node();
                Node tempNode = current.Next;

                newNode.Content = content;
                newNode.Previous = current;
                newNode.Next = tempNode;

                tempNode.Previous = newNode;
                current.Next = newNode;
            }
        }
        // function overload to receive either content or node
        public void AppendNode(object content)
        {
            Node newNode = new Node();
            newNode.Content = content;
            Node current = head;
            if(current == null)
            {
                head = newNode;
            }
            else
            {
                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
                newNode.Previous = current;
            }
        }
        public void AppendNode(Node toAppend)
        {
            Node current = head;
            if(current == null)
            {
                head = toAppend;
            }
            else
            {
                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = toAppend;
                toAppend.Previous = current;
            }
        }

        // remove functions
        public void RemoveBeginning()
        {
            if(head == null)
            {
                System.Console.WriteLine("List is empty.");
                return;
            }
            else
            {
                Node tempNode = head;
                head = tempNode.Next;
                head.Previous = null;
                tempNode = null;
            }
        }
        public void RemoveBefore(Node before)
        {
            Node current = head;
            while(current != before)
            {
                current = current.Next;
                if(current == null)
                {
                    break;
                }
            }

            if(current == null)
            {
                System.Console.WriteLine("Node: " + before + " does not exist.");
                return;
            }
            else
            {
                Node tempNode = current.Previous.Previous;
                Node tempNodeDelete = current.Previous;
                current.Previous = tempNode;
                tempNode.Next = current;
                tempNodeDelete = null;
            }
        }
        public void RemoveAfter(Node after)
        {
            Node current = head;
            while(current != after)
            {
                current = current.Next;
                if(current == null)
                {
                    break;
                }
            }

            if(current == null)
            {
                System.Console.WriteLine("Node: " + after + " does not exist.");
                return;
            }
            else
            {
                Node tempNode = current.Next.Next;
                Node tempNodeDelete = current.Next;
                current.Next = tempNode;
                tempNode.Previous = current;
                tempNodeDelete = null;
            }
        }

        // aux functions
        public int Length()
        {
            int length = 0;
            Node current = head;
            while(current != null)
            {
                length++;
                current = current.Next;
            }

            return length;
        }
        public void PrintNodes()
        {
            Node current = head;
            while(current.Next != null)
            {
                System.Console.WriteLine(current.Content);
                current = current.Next;
            }

            System.Console.WriteLine(current.Content);
        }
    }
}
