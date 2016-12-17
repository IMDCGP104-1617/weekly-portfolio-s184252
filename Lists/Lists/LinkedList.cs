using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class LinkedList<T>
    {
        private int size;

        public Node<T> head;

        public LinkedList()
        {
            head = null;
            size = 0;
        }

        ~LinkedList()
        {
            Clear();
        }

        public void InsertBeginning(Node<T> nodeToInsert)
        {
            if(IsEmpty())
            {
                head = nodeToInsert;

                size++;
            }
            else
            {
                nodeToInsert.Next = head;
                head = nodeToInsert;

                size++;
            }
        }

        // overloaded InsertBeginning function to create node containing entered data
        public void InsertBeginning(T content)
        {
            Node<T> newNode = new Node<T>(content);

            if(IsEmpty())
            {
                head = newNode;

                size++;
            }
            else
            {
                newNode.Next = head;
                head = newNode;

                size++;
            }
        }

        public void InsertAfter(Node<T> existingNode, Node<T> nodeToInsert)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current.Next == null)
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
                    current.Next = nodeToInsert;
                }
                else
                {
                    nodeToInsert.Next = current.Next;
                    current.Next = nodeToInsert;
                }

                size++;
            }
        }

        // overloaded InsertAfter function to create node containing entered data
        public void InsertAfter(Node<T> existingNode, T content)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current.Next == null)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                Node<T> nodeToInsert = new Node<T>(content);

                if(current.Next == null)
                {
                    current.Next = nodeToInsert;

                }
                else
                {
                    nodeToInsert.Next = current.Next;
                    current.Next = nodeToInsert;
                }

                size++;
            }
        }

        public void RemoveBeginning()
        {
            if(IsEmpty() == false)
            {
                Node<T> temp = head;

                if(head.Next != null)
                {
                    head = head.Next;
                }
                else
                {
                    head = null;
                }

                temp.Next = null;

                size--;
            }
            else
            {
                Console.WriteLine("List is empty, cannot remove head.");
            }
        }

        public void RemoveAfter(Node<T> existingNode)
        {
            if(IsEmpty() == false)
            {
                Node<T> current = head;

                while(current != existingNode)
                {
                    if(current.Next == null)
                    {
                        Console.WriteLine("Specified node " + existingNode.ToString() + " does not exist in list.");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if(current.Next.Next == null)
                {
                    current.Next = null;

                    size--;
                }
                else
                {
                    Node<T> temp = current.Next.Next;

                    current.Next.Next = null;
                    current.Next = temp;

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
