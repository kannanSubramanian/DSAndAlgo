using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    public partial class LinkedList
    {
          
        /* Approach1 */

        /* Scan the entire linked list and find the count of the LinkedList
         * Once we get the count divide it by 2. --> CountOfLinkedList/2
         * Iterate the linkedlist till CountOfLinkedList/2 and Pick the last element which is the middle element of the linked list */

        public int GetMiddleElementInLinkedList()
        {
            int middleEmelent = 0;
            int countOfLinkedList = 0;
            

            LinkedList lst = new LinkedList();

            lst.Add(new Node(10));
            lst.Add(new Node(20));
            lst.Add(new Node(30));
            lst.Add(new Node(40));
            lst.Add(new Node(50));
            lst.Add(new Node(60));

            Node current = lst.head;

            while (current != null)
            {
                countOfLinkedList = countOfLinkedList + 1;
                current = current.Next;
            }

            current = lst.head;
            int indx = 0;
            while (current != null)
            {
                middleEmelent = current.Value;
                indx = indx + 1;
                current = current.Next;
                if (indx >= (countOfLinkedList / 2))
                {
                    break;
                }
            }
            return middleEmelent;
        }

        /* Finding the middle element in only one pass */

       /* Have 2 pointers P1 and P2
        * Increment 2nd pointer by 2 hops and 1st pointer by 1 hop
        * If the 2nd pointer can perform 2 hops again repeat the same process till it can
        * When it cant perform 2 hops first pointer will be in the middle of the linked list.
        */


        public int GetMiddleElementInLinkedListWithOnlyOnePass()
        {

            LinkedList lst = new LinkedList();

            lst.Add(new Node(10));
            lst.Add(new Node(20));
            lst.Add(new Node(30));
            lst.Add(new Node(40));
            lst.Add(new Node(50));
            lst.Add(new Node(60));

            Node ptr1 = lst.head;
            Node ptr2 = lst.head;

            while (ptr2.Next != null && ptr2.Next.Next != null)
            {
                ptr2 = ptr2.Next.Next;
                ptr1 = ptr1.Next;
            }

            return ptr1.Value;
        }

    }
}
