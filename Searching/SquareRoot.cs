using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class SquareRoot
    {
        public static void floorSqrt(long x)
        {
            Console.WriteLine(bin_search(0, x, x));
        }

        public static long bin_search(long left, long right, long k)
        {
            long ans = 0;
            while (left <= right)
            {
                long mid = (left + right) / 2;
                var num = mid * mid;
                if (num == k)
                    return mid;
                else if (num > k)
                    right = mid - 1;
                else
                {
                    left = mid + 1;
                    ans = mid;
                }
            }

            return ans;
        }
    }
}
