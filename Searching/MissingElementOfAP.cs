using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class MissingElementOfAP
    {
        public static void fnMissingElementOfAP(int[] arr)
        {
            int mindiff = int.MaxValue;
            int value = -1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] - arr[i] < mindiff)
                    mindiff = arr[i + 1] - arr[i];
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + mindiff != arr[i + 1])
                {
                    value = arr[i] + mindiff;
                    break;
                }
            }

            Console.WriteLine(value);
        }

        public static void fnMissingElementAPBS(int[] arr)
        {
            int n = arr.Length;
            int diff = (arr[n - 1] - arr[0]) / n;

            int i = 0;
            int j = n - 1;
            int missingNum = -1;
            while (i <= j)
            {
                int mid = (i + j) / 2;

                if (arr[mid] != (arr[0] + (diff * mid)))
                {
                    j = mid--;
                }
                else
                {
                    if (arr[mid + 1] - arr[mid] == diff)
                    {
                        i = mid++;
                    }
                    else
                    {
                        missingNum = arr[mid] + diff;
                        break;
                    }
                }
            }

            Console.WriteLine(missingNum);
        }
    }
}
