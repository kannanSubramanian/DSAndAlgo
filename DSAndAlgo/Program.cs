using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSAndAlgo.Array;

namespace DSAndAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            DSAndAlgo.Array.Array arry = new Array.Array();
            bool hasDups = arry.CheckIfTheArrayHasDupsUsingHashSetApproach();
            Console.ReadKey();
            
        }
    }
}
