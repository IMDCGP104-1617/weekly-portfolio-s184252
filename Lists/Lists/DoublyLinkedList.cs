using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class DoublyLinkedList<T>
    {
        private int size;

        public Node<T> head;
        public Node<T> tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        ~DoublyLinkedList()
        {
            Clear();
        }

        public void InsertBeginning(Node<T> nodeToInsert)
        {
            if(IsEmpty())
            {
                head = nodeToInsert;
                tail = nodeToInsert;
            }
            else
            {
                nodeToInsert.Next = head;
                head.Previous = nodeToInsert;
                head = nodeToInsert;
            }

            size++;
        }

        // overloaded InsertBeginning function to create node containing entered data
        public void InsertBeginning(T content)
        {
            Node<T> newNode = new Node<T>(content);

            if(IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            size++;
        }

        public void InsertBefore(Node<T> existingNode, Node<T> nodeToInsert)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current == tail)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if(existingNode == head)
                {
                    InsertBeginning(nodeToInsert);
                }
                else
                {
                    Node<T> tempNode = current.Previous;

                    nodeToInsert.Next = current;
                    nodeToInsert.Previous = tempNode;
                    tempNode.Next = nodeToInsert;
                    current.Previous = nodeToInsert;

                    size++;
                }
            }
        }

        // overloaded InsertBefore function to create node containing entered data
        public void InsertBefore(Node<T> existingNode, T content)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current == tail)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if(existingNode == head)
                {
                    InsertBeginning(content);
                }
                else
                {
                    Node<T> tempNode = current.Previous;
                    Node<T> newNode = new Node<T>(content);

                    newNode.Next = current;
                    newNode.Previous = tempNode;
                    tempNode.Next = newNode;
                    current.Previous = newNode;

                    size++;
                }
            }
        }

        public void InsertAfter(Node<T> existingNode, Node<T> nodeToInsert)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current == tail)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if(current == tail)
                {
                    current.Next = nodeToInsert;
                    nodeToInsert.Previous = current;
                    tail = nodeToInsert;
                }
                else
                {
                    Node<T> tempNode = current.Next;

                    current.Next = nodeToInsert;
                    nodeToInsert.Previous = current;
                    nodeToInsert.Next = tempNode;
                    tempNode.Previous = nodeToInsert;
                }

                size++;
            }
        }

        // overloaded InsertBefore function to create node containing entered data
        public void InsertAfter(Node<T> existingNode, T content)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current == tail)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                Node<T> newNode = new Node<T>(content);

                if(current == tail)
                {
                    current.Next = newNode;
                    newNode.Previous = current;
                    tail = newNode;
                }
                else
                {
                    Node<T> tempNode = current.Next;

                    current.Next = newNode;
                    newNode.Previous = current;
                    newNode.Next = tempNode;
                    tempNode.Previous = newNode;
                }

                size++;
            }
        }

        public void RemoveBeginning()
        {
            if(IsEmpty() == false)
            {
                Node<T> temp = head;

                if(head != tail)
                {
                    head = head.Next;
                    head.Previous = null;
                }
                else
                {
                    head = null;
                    tail = null;
                }

                temp.Next = null;

                size--;
            }
            else
            {
                Console.WriteLine("List is empty, cannot remove head.");
            }
        }

        public void RemoveBefore(Node<T> existingNode)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current == tail)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if(current == head)
                {
                    Console.WriteLine("No node to remove.");
                    return;
                }
                else if(current.Previous == head)
                {
                    current.Previous.Next = null;
                    current.Previous = null;
                    head = existingNode;

                    size--;
                }
                else
                {
                    Node<T> tempPrePre = current.Previous.Previous;

                    current.Previous.Previous = null;
                    current.Previous.Next = null;
                    current.Previous = tempPrePre;
                    tempPrePre.Next = current;

                    size--;
                }
            }
        }

        public void RemoveAfter(Node<T> existingNode)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current == tail)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if(current.Next == null)
                {
                    Console.WriteLine("No node to remove.");
                    return;
                }
                else if(current.Next == tail)
                {
                    current.Next.Previous = null;
                    current.Next = null;
                    tail = current;

                    size--;
                }
                else
                {
                    Node<T> temp = current.Next.Next;

                    current.Next.Next = null;
                    current.Next.Previous = null;
                    current.Next = temp;
                    temp.Previous = current;

                    size--;
                }
            }
        }

        public void Clear()
        {
            while(IsEmpty() == false)
            {
                RemoveBeginning();
            }
        }

        // traverses list to count nodes - O(n), not as fast as Size
        public int Length()
        {
            int count = 0;

            Node<T> current = head;

            while(current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        // alternative method of retrieving size of list, with a speed of O(1)
        public int Size
        {
            get
            {
                return size;
            }
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void DisplayList()
        {
            if(IsEmpty() == true)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                Node<T> current = head;

                while(current != null)
                {
                    Console.WriteLine(current.Content);
                    current = current.Next;
                }
            }
        }
    }
}
