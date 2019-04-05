using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class PeakElement
    {
        public static void fnPeakElement(int[] arr)
        {
            int peakIndex = -1;
            int val = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 && arr[i] > arr[i + 1])
                {
                    val = 1;
                    break;
                }
                else if (i == arr.Length - 1 && arr[i] > arr[i - 1])
                {
                    val = 1;
                    break;
                }
                else
                {
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                        val = 1;
                    break;
                }
            }

            Console.WriteLine(val);
        }
    }
}
