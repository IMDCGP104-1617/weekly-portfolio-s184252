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
            Stack<string> testStack = new Stack<string>();

            var firstNode = new Node<string>("bottom of stack");
            var secondNode = new Node<string>("middle of stack");
            var thirdNode = new Node<string>("top of stack");

            testStack.Push(firstNode);
            testStack.Push(secondNode);
            testStack.Push(thirdNode);

            testStack.DisplayList();
        }
    }
}
