using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            for(int i = 0; i < 50; i++)
            {
                myStack.StackPush(i);
            }

            myStack.StackPush((int)300);
            myStack.StackPop();

            myStack.StackPrint();
            Console.ReadLine();
        }
    }
}
