using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Array
{
    public static class GetPairOfSumInSortedArray
    {
        public static (int, int) GetPair(int sum, int[] items)
        {
            if (items == null) return (-1, -1);
            int leftBound = 0;
            int rightBound = items.Length-1;
            int total = 0;
            while (leftBound <= rightBound)
            {
                total = items[leftBound] + items[rightBound];
                if (sum == total)
                    return (leftBound, rightBound);
                if (sum < total)
                {
                    rightBound--;
                   
                }
                if (sum > total)
                {
                    leftBound++;
                }
            }

            return (leftBound, rightBound);
        }


    }
}
