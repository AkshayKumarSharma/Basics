using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.LinkedList
{
   public class LinkedList
    {
        private Node Head { get; set; }

        public void PrintAllNodes()
        {
            var node = Head;

            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void AddFirst(int number)
        {
            Node node = new Node(number);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
    }
}
