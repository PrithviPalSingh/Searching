using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class FloorOfSortedArray
    {
        public static void fnFloorOfSortedArray(int[] arr, int k)
        {
            Console.WriteLine(bin_search(arr, 0, arr.Length - 1, k));
        }

        public static int bin_search(int[] A, int left, int right, int k)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (A[mid] == k)
                    return mid;
                else if (A[mid] > k)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            if (right >= 0)
                return right;

            return -1;
        }
    }
}
