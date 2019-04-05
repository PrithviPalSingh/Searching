using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    /// <summary>
    /// Very good insight of binary search
    /// </summary>
    class SearchInRotatedArray
    {
        public static void fnSearchInRotatedArray(int[] arr, int k)
        {
            int index = -1;
            index = bin_search(arr, 0, arr.Length - 1, k);
            Console.WriteLine(index);
        }

        private static int bin_search(int[] A, int left, int right, int k)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;

            if (A[mid] == k)
                return mid;

            if (A[mid] >= A[left])
            {
                if (k >= A[left] && k <= A[mid])
                    return bin_search(A, left, mid - 1, k);

                return bin_search(A, mid + 1, right, k);
            }

            if (k >= A[mid] && k <= A[right])
                return bin_search(A, mid + 1, right, k);

            return bin_search(A, left, mid - 1, k);

        }
    }
}
