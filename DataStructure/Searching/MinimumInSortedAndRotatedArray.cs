using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Search
{
    //Input: {5, 6, 1, 2, 3, 4}
    //Output: 1
    public class MinimumInSortedAndRotatedArray
    {
        public void GetMinimum()
        {
            int[] items = { 5, 6, 1, 2, 3, 4 };
            int minimum = 0;
            minimum = BinarySearch(items, 0, items.Length - 1);

            Console.WriteLine($"minimum element found is {minimum}");
        }

        private int BinarySearch(int[] items, int start, int end)
        {
             // Find mid 
            // (low + high)/2 
            int mid = start + (end - start) / 2;

            if (mid < end && (items[mid] > items[mid + 1]))
                return items[mid + 1];
            if (mid > start && items[mid] < items[mid - 1])
                return items[mid];
            if (items[end] > items[mid])
                return BinarySearch(items, start, mid - 1);
            else
                return BinarySearch(items, mid + 1, end);
            
        }
    }
}
