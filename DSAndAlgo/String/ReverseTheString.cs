using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.String
{
    public partial class String
    {

        /* Reverse the string */

        /* Character in the string can accessed using index like string[0],string[1] etc  
         * Find the lenght of the string, Iterate the string reversly and store all the characters in the string builder till the coutre reachers zero
         */

        public string ReverseTheString()
        {
            string str = "Hello world, its beautiful out here !!!";
            StringBuilder sb = new StringBuilder();
            int strLength = str.Length;
            for (int i = strLength - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }


        




    }
}
