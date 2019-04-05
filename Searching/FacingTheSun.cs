using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class FacingTheSun
    {
        public static void fnFacingTheSun(int[] arr)
        {
            int count = 0;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                {
                    count++;
                    max = arr[i];
                }
            }

            Console.WriteLine(count);
        }
    }
}
