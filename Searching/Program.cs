using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberOfOccurences.fnNumberOfOccurences(new int[7] { 1, 1, 2, 2, 2, 2, 3 }, 4);
            //Console.WriteLine(BinarySearch.bin_search(new int[] { 1, 2, 3, 4, 5 }, 0, 4, 4));
            //SquareRoot.floorSqrt(24);

            //MissingNumberInAnArray.fnMissingNumberInAnAray(new int[] { 1, 2, 3, 5 }, 5);
            //FloorOfSortedArray.fnFloorOfSortedArray(new int[] { 1, 2, 8, 10, 11, 12, 19 }, 10);
            //MissingElementOfAP.fnMissingElementAPBS(new int[] { -11, 19, 34, 49, 64 });

            //SearchInRotatedArray.fnSearchInRotatedArray(new int[] { 5, 6, 7, 8, 9, 10, 1, 2, 3 }, 10);

            //FindTransitionPoint.fbFindTransitionPoint(new int[] { 0, 0, 0, 1, 1 });

            //CommonElements.fnCommonElements(
            //    new int[] { 1, 5, 10, 20, 40, 80 },
            //    new int[] { 6, 7, 20, 80, 100 },
            //    new int[] { 3, 4, 15, 20, 30, 70, 80, 120 });

            SmallestPosiitiveNumber.fnSmallestPositiveNumber(
                new int[] { 0, -10, 1, 3, -20 });

            Console.Read();
        }
    }
}
