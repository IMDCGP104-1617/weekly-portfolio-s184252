using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Stack<T>
    {
        private int size;

        public Node<T> top;

        public Stack()
        {
            top = null;
            size = 0;
        }

        ~Stack()
        {
            Clear();
        }

        public void Push(Node<T> nodeToPush)
        {
            if(IsEmpty() == true)
            {
                top = nodeToPush;
            }
            else
            {
                nodeToPush.Next = top;
                top = nodeToPush;
            }

            size++;
        }

        public void Push(T content)
        {
            Node<T> newNode = new Node<T>(content);

            if(IsEmpty() == true)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }

            size++;
        }

        public Node<T> Pop()
        {
            if(IsEmpty() == true)
            {
                Console.WriteLine("Stack is empty, no nodes to pop.");
                return null;
            }
            else
            {
                Node<T> tempNode = top;
                top = top.Next;
                tempNode.Next = null;

                size--;

                return tempNode;
            }
        }

        public T Peek()
        {
            return top.Content;
        }

        public void Clear()
        {
            while(IsEmpty() == false)
            {
                Pop();
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
            return (top == null);
        }

        public void DisplayList()
        {
            if(IsEmpty() == true)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                Node<T> current = top;

                while(current != null)
                {
                    Console.WriteLine(current.Content);
                    current = current.Next;
                }
            }
        }
    }
}
