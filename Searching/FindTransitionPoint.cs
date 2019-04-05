using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class FindTransitionPoint
    {
        public static void fbFindTransitionPoint(int[] arr)
        {
            int n = arr.Length;
            int index = bin_search(arr, 0, n - 1);
            Console.WriteLine(index);
        }

        private static int bin_search(int[] A, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;

            if (A[mid] == 1 && A[mid - 1] == 0)
                return mid;

            if (A[mid] == 1)
                return bin_search(A, left, mid - 1);

            return bin_search(A, mid + 1, right);
        }
    }
}
