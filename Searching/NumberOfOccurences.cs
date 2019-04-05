using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class NumberOfOccurences
    {
        public static void fnNumberOfOccurences(int[] arr, int num)
        {
            int low = 0;
            int high = arr.Length - 1;
            int count = 0;
            fnInner(arr, num, low, high, ref count);

            if (count == 0)
                Console.WriteLine(-1);
            else
                Console.WriteLine(count);
        }

        private static void fnInner(int[] arr, int num, int low, int high, ref int count)
        {
            int mid = (high + low) / 2;

            if (high < low)
                return;

            if (arr[mid] > num)
            {
                fnInner(arr, num, low, mid - 1, ref count);
            }
            else if (arr[mid] < num)
            {
                fnInner(arr, num, mid + 1, high, ref count);
            }
            else
            {
                count++;
                fnInner(arr, num, low, mid - 1, ref count);
                fnInner(arr, num, mid + 1, high, ref count);
            }
        }
    }
}
