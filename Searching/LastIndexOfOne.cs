using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class LastIndexOfOne
    {
        public static void fnLastIndexOfOne(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
