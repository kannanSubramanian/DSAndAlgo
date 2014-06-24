using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.Stack
{

    public class StackMain
    {
        public void InitStack()
        {
            DSAndAlgo.Stack.Stack<int> stck = new Stack<int>(5);
            for (int i = 1; i <= 5; i++)
            {
                stck.Push(i*10);
            }

            stck.Display();
            Console.WriteLine("Top elemnts in the stack is " + stck.Peak());

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

    public class Stack<T>
    {
        public T[] StackArray;
        public int Top;

        public Stack(int StackCapacity)
        {
            StackArray = new T[StackCapacity];
            Top = 0;
        }

        /* Before adding a element in stack, Make sure the stack is not full */
        public void Push(T element)
        {
            if (Top >= StackArray.Length)
            {
                Console.WriteLine("Stack is full, Can't add elements to it");
            }

            else
            {
                StackArray[Top] = element;
                Top = Top + 1;
            }
        }

        /* Before removing a removing from the array check if the array is not empty */
        public T Pop()
        {
            if ((Top - 1) < 0)
            {
                Console.WriteLine("Stack is empty and elements can be popped");
                return default(T);
            }
            else
            {
                Top = Top - 1;
                return StackArray[Top];
            }
        }

        public T Peak()
        {
            if ((Top - 1) < 0)
            {
                Console.WriteLine("Stack is empty and elements can be popped");
                return default(T);
            }

            else
            {
                return StackArray[Top - 1];
            }
        }

        public void Display()
        {
            Console.WriteLine("Current Stack Elements");
            for (int i = Top - 1; i >= 0; i--)
            {
                Console.WriteLine(StackArray[i]);
            }
        }
            
    
    }

}
