using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSAndAlgo
{
    public partial class LinkedList
    {
        private LinkedList _ConstructLinkedListWithLoop()
        {
            Node n1 = new Node(10);
            Node n2 = new Node(20);
            Node n3 = new Node(30);
            Node n4 = new Node(40);
            Node n5 = new Node(50);
            Node n6 = new Node(60);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n3;

            LinkedList lnkdLst = new LinkedList();
            lnkdLst.head = n1;

            return lnkdLst;        
        }

        /* =============  2 pointers approach ============= */

         /*
         * Have 2 pointes slow and fast.
         * Initialize both of them with the Head node.
         * Then increment slow pointer by 1 and fast pointer by 2 with respect to their current position
         * If there is loop then eventually both the pointers will meet.
         */

        public bool HasLoopInLinkedList1stApproach()
        {
            bool hasLoop = false;
            LinkedList lst = _ConstructLinkedListWithLoop();

            if (lst == null || lst.head == null || lst.head.Next == null)
            {
                hasLoop = false;
                return hasLoop;
            }

            Node slowPtr = lst.head;
            Node fastPtr = lst.head;

            while (slowPtr != null && fastPtr != null && fastPtr.Next != null && fastPtr.Next.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next.Next;

                if (slowPtr.Value == fastPtr.Value)
                {
                    hasLoop = true;
                    return hasLoop;
                }
            }

            return hasLoop;
        }

        /* ========== Hash set approach ========== */

        /*
         * Have a HastSet and add the value of first node in it.
         * Create a pointer and point it to 2nd node(Head.next) of the linked list
         * If the value of current pointer is alredy in HastSet then loop exist
         * Else add the value of the current pointer to the hash set and increment the currcnt pointer by 1
         * Loop the last 2 steps till the current pointer is null.
        */ 

        public bool HasLoopInLinkedList2ndApproach()
        {
            bool hasLoop = false;
            LinkedList lst = _ConstructLinkedListWithLoop();

            HashSet<int> hashMap = new HashSet<int>();

            if (lst == null || lst.head == null || lst.head.Next == null)
            {
                hasLoop = false;
                return hasLoop;
            }

            hashMap.Add(lst.head.Value);
            Node currentPtr = lst.head.Next;

            while (currentPtr != null)
            {
                if (hashMap.Contains(currentPtr.Value))
                {
                    hasLoop = true;
                    return hasLoop;
                }
                else
                {
                    hashMap.Add(currentPtr.Value);
                    currentPtr = currentPtr.Next;
                }
            }

            return hasLoop;

        }









    }
}
