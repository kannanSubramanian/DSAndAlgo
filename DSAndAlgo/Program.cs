using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSAndAlgo.Array;
using DSAndAlgo.String;

namespace DSAndAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();

            lst.Add(new Node(10));
            lst.Add(new Node(20));
            lst.Add(new Node(30));
            lst.Add(new Node(40));
            lst.Add(new Node(50));
            lst.Add(new Node(60));

            lst.Length();
            Console.ReadKey();
            
        }
    }
}
