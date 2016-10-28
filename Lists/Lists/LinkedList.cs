using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class LinkedList
    {
        public class Node
        {
            public object Content;
            public Node Next;
        }

        private Node head;

        public LinkedList()
        {
            head = null;
        }

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
                newNode.Next = head;
                head = newNode;
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
                newNode.Next = current.Next;
                current.Next = newNode;
                newNode.Content = content;
            }
        }

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
            }
        }

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
                tempNode = null;
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
                tempNodeDelete = null;
            }
        }

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
