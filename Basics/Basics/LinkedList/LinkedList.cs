using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> Head { get; set; }

        public void PrintAllNodes()
        {
            var node = Head;

            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void AddFirst(T number)
        {
            Node<T> node = new Node<T>(number);

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
        public void AddLast(T number)
        {
            Node<T> node = new Node<T>(number);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                var current = Head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;

            }
        }

    }
}
