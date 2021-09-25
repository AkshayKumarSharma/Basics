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

            linkedList.PrintAllNodes();
        }
    }
}
