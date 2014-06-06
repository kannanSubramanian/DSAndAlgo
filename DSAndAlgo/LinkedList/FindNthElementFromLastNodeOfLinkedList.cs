﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    public partial class LinkedList
    {
        /********* Program to find the nth Element from the last of the linked list **************/
        /* Given a linked list 10,20,30,40,50,60 3rd elemt from the last is 40. */

        /* Approach 1 with extra space */

        public int FindKthElementFromLastNodeWithExtraSpace()
        {
            int nthElementFromLsat = 3;
            int linkedListLength = 6;
            
            LinkedList lst = new LinkedList();

            lst.Add(new Node(10));
            lst.Add(new Node(20));
            lst.Add(new Node(30));
            lst.Add(new Node(40));
            lst.Add(new Node(50));
            lst.Add(new Node(60));

            int[] lstValues = new int[6];
            int indx = 0;

            Node current = lst.head;
            while (current != null)
            {
                lstValues[indx] = current.Value;
                indx++;
                current = current.Next;
            }

            return lstValues[linkedListLength - nthElementFromLsat];

        }

        public int FindKthElementFromLastNode()
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

            int n = 3;
            for (int i = 0; i < n - 1; i++)
            {
                ptr2 = ptr2.Next;
            }

            while (ptr2.Next != null)
            {
                ptr1 = ptr1.Next;
                ptr2 = ptr2.Next;
            }

            return ptr1.Value;

        }





    }
}
