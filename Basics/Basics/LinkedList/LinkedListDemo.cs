using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.LinkedList
{
    public class LinkedListDemo
    {
        public void IntegerLinkedList()
        {
            var intLinkedList = new LinkedList<int>();
            intLinkedList.AddFirst(1);
            intLinkedList.AddFirst(2);
            intLinkedList.AddFirst(3);

            intLinkedList.AddLast(4);
            intLinkedList.AddLast(5);

            intLinkedList.AddFirst(6);
            intLinkedList.AddFirst(7);

            intLinkedList.AddLast(8);
            intLinkedList.AddFirst(9);

            intLinkedList.PrintAllNodes();
        }

        public void StringLinkedList()
        {
            var stringlinkedList = new LinkedList<string>();

            stringlinkedList.AddFirst("a");
            stringlinkedList.AddFirst("b");
            stringlinkedList.AddLast("c");
            stringlinkedList.AddLast("d");
            stringlinkedList.AddFirst("e");
            stringlinkedList.AddFirst("f");
            stringlinkedList.AddLast("g");
            stringlinkedList.AddFirst("h");

            stringlinkedList.PrintAllNodes();
        }
    }
}
