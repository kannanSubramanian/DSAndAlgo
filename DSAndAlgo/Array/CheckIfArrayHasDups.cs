using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.Array
{
    public partial class Array
    {
        /*  Brute force approach */

        /*  Check every element of the array with every othere element in the array */

        int[] array = new int[] { 2, 1, 100, 10, 7, 11, 13, 16, 16 };

        public bool CheckIfArrayHasDupsUsingBruteForceApproach()
        {
            bool hasDups = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        hasDups = true;
                    }
                }
            }
            return hasDups;
        }


        /* Has set Approach */

        /* Scan the entire array and try to add every scanned element in a HashSet. 
         * When adding the element in the HashSet, Check if the elemnt is already there in the HastSet. 
         * If the element is alredy present the array has duplicate elements */


        public bool CheckIfTheArrayHasDupsUsingHashSetApproach()
        {
            bool hasDups = false;

            HashSet<int> hasmap = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!hasmap.Contains(array[i]))
                {
                    hasmap.Add(array[i]);
                }
                else
                {
                    hasDups = true;
                    break;
                }
            }

            return hasDups;
        }





        
    }
}
