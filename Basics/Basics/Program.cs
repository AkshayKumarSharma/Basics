using System;
using Basics.LinkedList;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);

            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.AddFirst(6);
            linkedList.AddFirst(7);

            linkedList.AddLast(8);
            linkedList.AddFirst(9);

            linkedList.PrintAllNodes();
        }
    }
}
