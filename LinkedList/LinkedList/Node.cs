using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;
    }

    public class NodeOperation
    {
        Node head = new Node();
        Node current;

        public NodeOperation()
        {
            head.Value = 1;
            head.Next = null;
            current = head;
        }

        public void InsertAtLast(int value)
        {

            Node lastNodeToAdd = new Node();
            lastNodeToAdd.Value = value;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = lastNodeToAdd;

        }

        public void Print()
        {
            for (Node currentNode = head; currentNode != null;)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            //var current = head;
            //while (current != null)
            //{
            //    Console.WriteLine(current.Value);
            //    current = current.Next;
            //}
        }
    }
}
