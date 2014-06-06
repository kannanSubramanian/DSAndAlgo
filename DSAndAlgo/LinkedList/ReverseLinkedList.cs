using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**************** Reverse the Linked List *************/


namespace DSAndAlgo
{
    public partial class LinkedList
    {
        public LinkedList ReverseLinkedList()
        {
            LinkedList lst = new LinkedList();

            lst.Add(new Node(10));
            lst.Add(new Node(20));
            lst.Add(new Node(30));
            lst.Add(new Node(40));
            lst.Add(new Node(50));

            Node prev = null;
            Node current = lst.head;
            Node next = current.Next;

            while (next != null)
            {
                current.Next = prev;
                prev = current;
                current = next;
                next = current.Next;
            }
            current.Next = prev;
            lst.head = current;

            return lst;

        }
    }
}
