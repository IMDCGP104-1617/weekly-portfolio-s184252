using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Queue<T>
    {
        private int size;

        public Node<T> front;
        public Node<T> end;

        public Queue()
        {
            front = null;
            end = null;
            size = 0;
        }

        ~Queue()
        {
            Clear();
        }

        public void Enqueue(Node<T> nodeToPush)
        {
            if(IsEmpty() == true)
            {
                front = nodeToPush;
                end = nodeToPush;
            }
            else
            {
                nodeToPush.Next = end;
                end = nodeToPush;
            }

            size++;
        }

        public void Enqueue(T content)
        {
            Node<T> newNode = new Node<T>(content);

            if(IsEmpty() == true)
            {
                front = newNode;
                end = newNode;
            }
            else
            {
                newNode.Next = end;
                end = newNode;
            }

            size++;
        }

        public Node<T> Dequeue()
        {
            if(IsEmpty() == true)
            {
                Console.WriteLine("Queue is empty, no items returned");
                return null;
            }
            else
            {
                Node<T> current = end;

                if(current == front)
                {
                    end = null;
                    front = null;

                    size--;

                    return current;
                }
                else
                {
                    while(current.Next != front)
                    {
                        current = current.Next;
                    }

                    Node<T> tempNode = current.Next;

                    front = current;

                    current.Next = null;
                    tempNode.Next = null;

                    size--;

                    return tempNode;
                }
            }
        }

        public T Peek()
        {
            return front.Content;
        }

        public void Clear()
        {
            while(IsEmpty() == false)
            {
                Dequeue();
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public bool IsEmpty()
        {
            return (front == null);
        }

        public void DisplayList()
        {
            if(IsEmpty() == true)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                Node<T> current = end;

                while(current != null)
                {
                    Console.WriteLine(current.Content);
                    current = current.Next;
                }
            }
        }
    }
}