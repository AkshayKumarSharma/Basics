using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.LinkedList
{
    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;
        public Node(T d)
        {
            data = d;
            next = null;
        }
    }
}
