using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Node<T>
    {
        public T Content;
        public Node<T> Next = null;
        public Node<T> Previous = null;

        public Node()
        {
            Content = default(T);
        }
        public Node(T content)
        {
            Content = content;
        }
    }
}
