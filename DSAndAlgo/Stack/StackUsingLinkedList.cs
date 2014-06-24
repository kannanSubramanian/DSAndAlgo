using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.Stack
{
    public class StackUsingListMain
    {
        public void InitStack()
        {
            StackUsingLinkedList stck = new StackUsingLinkedList();
            for (int i = 1; i <= 5; i++)
            {
                stck.Push(i * 10);
            }

            stck.Display();
            Console.WriteLine("Top elemnts in the stack is " + stck.peek());

            for (int i = 1; i <= 3; i++)
            {
                var element = stck.Pop();
            }

            stck.Display();


            for (int i = 1; i <= 3; i++)
            {
                var element = stck.Pop();
            }

            Console.ReadKey();

        }
    }

    public class StackUsingLinkedList
    {
        public Node Top;

        public Node First;

        public int StackCount;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (First == null)
            {
                First = newNode;
                First.Next = null;
            }
            else
            {
                Node PrevFirst = First;
                First = newNode;
                First.Next = PrevFirst;
            }
        }

        public int Pop()
        {
            int poppedData = -1;
            if (First == null)
            {
                Console.WriteLine("Stack is Empty.. So can't pop data from it");
            }
            else
            {
                poppedData = First.Value;
                First = First.Next;
            }
            return poppedData;
        }

        public int peek()
        {
            int poppedData = -1;
            if (First == null)
            {
                Console.WriteLine("Stack is Empty.. So can't pop data from it");
            }
            else
            {
                poppedData = First.Value;
            }
            return poppedData;
        }

        public void Display()
        {
            Node top = First;
            while (top != null)
            {
                Console.WriteLine(top.Value);
                top = top.Next;
            }
        }
    
    }
}
