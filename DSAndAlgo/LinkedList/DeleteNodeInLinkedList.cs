using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    public partial class LinkedList
    {
        /* Algorithm */

        /*
         
         * 1. If Head node has to be deleted and if Head.Next is null ==> set the Head as null
         * 2. If Head node has to be deleted and If Head.Next is not null ==> set the Head as Head.Next
         * 3. If the node which is to deleted is in between
         * 4. Have 3 pointers current,Next and Previous and set Current as Head.Next, Previous as Head and Next as Current.Next.
         * 5. Iterate the list and check if any of the node value matches the node to be deteled
         * 6. If a match is found set the Previous.next as Next and return
         * 7. If a match is not found increment every pointer to their correpsonding next node.
         
         */

        public void Delete(int value)
        {
            bool isNodeFound = false;

            if (head == null)
            {
                throw new Exception("Linked list is empty");
            }

            if (head.Value == value)
            {
                isNodeFound = true;
                if (head.Next == null)
                {
                    head = null;
                }
                else
                {
                    Node currentHead = head.Next;
                    head = currentHead;
                }
            }

            if (!isNodeFound)
            {
                Node curPtr = head.Next;
                Node prevPtr = head;
                Node nextPtr = curPtr.Next;

                while (curPtr != null)
                {
                    if (curPtr.Value == value)
                    {
                        prevPtr.Next = nextPtr;
                        isNodeFound = true;
                        break;
                    }

                    prevPtr = curPtr;
                    curPtr = nextPtr;
                    nextPtr = nextPtr.Next;
                }
            }
        }
    }
}
