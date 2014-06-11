using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }

    }

    public partial class LinkedList
    {
        public Node head;
        public Node current;

        public void Add(Node node)
        {
            if (head == null)
            {
                head = node;
                current = node;
            }
            else
            {
                current.Next = node;
                current = node;
            }
        }

        public int Length()
        {
            int lstLength = 0;

            if (head == null)
            {
                return lstLength;
            }

            Node currentPtr = head;
            while (currentPtr != null)
            {
                lstLength += 1;
                currentPtr = currentPtr.Next;
            }

            return lstLength;
        }

    }
}
