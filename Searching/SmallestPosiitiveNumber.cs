using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class SmallestPosiitiveNumber
    {
        public static void fnSmallestPositiveNumber(int[] arr)
        {
            int max = arr.Max();
            int[] tempArr = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    tempArr[arr[i]]++;
            }

            int j = 0;
            for (j = 1; j < tempArr.Length; j++)
            {
                if (tempArr[j] == 0)
                {
                    break;
                }
            }

            Console.WriteLine(j);
        }
    }
}
