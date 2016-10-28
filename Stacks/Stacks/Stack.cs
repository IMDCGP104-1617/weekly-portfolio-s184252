using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Stack
    {
        public class Item
        {
            public object Content;
            public Item Next;
        }

        public Stack()
        {
            count = 0;
            top = null;
        }

        private Item top = null;
        private int count = 0;

        public void StackPush(object content)
        {
            Item newItem = new Item();
            newItem.Content = content;

            if(top == null)
            {
                top = newItem;
            }
            else
            {
                Item tempItem = top;
                top = newItem;
                newItem.Next = tempItem;
            }

            count++;
        }

        public object StackPop()
        {
            if(top == null)
            {
                System.Console.WriteLine("Stack is empty");
                return null;
            }
            else
            {
                Item tempItem = top;
                top = tempItem.Next;
                count--;
                return tempItem.Content;
            }
        }

        public bool isEmpty()
        {
            if(top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object StackPeek()
        {
            return top.Content;
        }

        public int StackCount()
        {
            return count;
        }

        public void StackPrint()
        {
            Item tempItem = top;

            while(tempItem != null)
            {
                System.Console.WriteLine(tempItem.Content);
                tempItem = tempItem.Next;
            }
        }

        ~Stack()
        {
            while(top != null)
            {
                top = top.Next;
            }
        }
    }
}
