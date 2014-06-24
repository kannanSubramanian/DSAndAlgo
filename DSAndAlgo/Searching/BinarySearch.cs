using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.Searching
{
    public class BinarySearch
    {

        /* Algorith */

        /*
        * 1. Have 2 variables low and high and set low as first element in the array and high as last element in the array.
        * 2. We need to calculate the middle of the array and the formula used is mid = (low + high) / 2
        * 3. Till low is less than high
        * 4. Check if the middle element is equal to key and if so return it.
        * 5. Else if the middle elment is greater than key move the high to middle element - 1
        * 6. If the Middle element is less than key move the low to  middle element + 1
        * 7. For every iteration calcuate the middle element using the same formula mid = (low + high) / 2;
        */

        public void Init()
        {
            int[] array = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                array[i - 1] = i;
            }

            BinarySearch bs = new BinarySearch();
            bs.BinarySerach(array, 33);
        }
    
        public bool BinarySerach(int[] array, int key)
        {
            bool isFound = false;

            int numberOfIterations = 0;
            int low = 0;
            int high = array.Length - 1;
            int mid = (low + high) / 2;

            while (low <= high)
            {
                numberOfIterations += 1;
                if (array[mid] == key)
                {
                    isFound = true;
                    break;
                }
                else if (array[mid] < key)
                {
                    low = mid + 1;
                }
                else if (array[mid] > key)
                {
                    high = mid - 1;
                }

                mid = (low + high) / 2;
            }
            return isFound;
        }

    }
}
