using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class MissingNumberInAnArray
    {
        public static void fnMissingNumberInAnAray(int[] arr, int n)
        {
            int[] tempArr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[arr[i]-1]++;
            }

            for (int i = 0; i < tempArr.Length; i++)
            {
                if (tempArr[i] == 0)
                {
                    Console.WriteLine(i + 1);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
