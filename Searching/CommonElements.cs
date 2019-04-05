using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class CommonElements
    {
        public static void fnCommonElements(int[] arr1, int[] arr2, 
            int[] arr3)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            string str = string.Empty;
            while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
                {
                    if (!str.Contains(arr1[i].ToString()))
                        str += arr1[i] + " ";
                    i++;
                    j++;
                    k++;
                }
                else if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr3[k])
                    j++;
                else
                    k++;
            }

            if (!string.IsNullOrWhiteSpace(str))
                Console.WriteLine(str);
            else
                Console.WriteLine(-1);
        }
    }
}
