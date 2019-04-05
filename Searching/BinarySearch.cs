using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class BinarySearch
    {
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

            return -1;
        }
    }
}
