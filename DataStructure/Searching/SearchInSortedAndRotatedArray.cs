using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Search
{
    public class SearchInSortedAndRotatedArray
    {
        //INPUT : {5, 6, 7, 8, 9, 10, 1, 2, 3}
        //Search : 3

        //OUTPUT : Found at index 8

        public void Search()
        {
            int[] items = { 5, 6, 7, 8, 9, 10, 1,2,3,4 };
            int searchItem = 3;
            int foundAt = -1;

            foundAt = BinarySearch(items, 0, items.Length - 1, searchItem);

            if (foundAt == -1)
            {
                Console.WriteLine("item not found");
            }
            else
                Console.Write($"item found at : {foundAt}");
        }

        private int BinarySearch(int[] arr , int start, int end, int searchItem)
        {
            
            int mid = (start + end) / 2;
            if (arr[mid] == searchItem)
            {
                return mid;
            }
            if (arr[start] < arr[mid]) // to find array is sorted till mid
            {
                if ((searchItem > arr[start]) && (searchItem < arr[mid]))
                    return BinarySearch(arr, start, mid - 1, searchItem);
                else
                    return BinarySearch(arr, mid + 1, end, searchItem);
            }
            if ((searchItem >= arr[mid]) && (searchItem <= arr[end])) //If array not sorted till mid then definately it will be sorted agter mid
            {
                
                    return BinarySearch(arr, mid + 1, end, searchItem);
               
            }
            else
            return BinarySearch(arr, start, mid - 1, searchItem);
            
           
        }
    }
}
