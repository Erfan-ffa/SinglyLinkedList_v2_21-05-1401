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

        public void InsertNodeAtFirst(int value) 
        {
            Node nodeToAddFirst = new Node();

            nodeToAddFirst.Value = value;
            nodeToAddFirst.Next = head;
            head = nodeToAddFirst;
        }


        public void InsertNodeAtLast(int value)
        {

            Node nodeToAddLast = new Node();
            nodeToAddLast.Value = value;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = nodeToAddLast;

        }

        public void Print()
        {
            for (Node currentNode = head; currentNode != null;)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            //var tempNode = head;
            //while (tempNode != null)
            //{
            //    Console.WriteLine(tempNode.Value);
            //    tempNode = tempNode.Next;
            //}
        }
    }
}
