using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Array
{
    //INPUT Items = {3,4,5,1,2}
    //SearchItem = 5
    //Output Found At Index = 2
    public static class SearchInSortedAndRotated
    {
        //Search with O(n)
        public static int SearchElement(int ele, int[] items)
        {
            int foundAt = -1;
            bool found = false;
            if (items == null) return foundAt;
            for (int i = 0; i < items.Length; i++)
            {
                if (ele == items[i])
                {
                    found = true;
                }

                if (found)
                {
                    foundAt = i;
                    break;
                }

            }

            return foundAt;
        }

        //Search with O(logn)
        public static int SearchElementOptimize(int ele, int[] items)
        {
            int foundAt = -1;
            if (items == null) return foundAt;
            foundAt = GetElementAtIndex(items, 0,items.Length-1,ele );
            return foundAt;

        }

        private static int GetElementAtIndex(int[] items, int leftIndex,int rightIndex,int searchItem)
        {
            int mid = (leftIndex + rightIndex) / 2;
            if (items[mid] == searchItem)
            {
                return mid;
            }

            if (leftIndex >= 0 && rightIndex <= items.Length)
            {
                if (items[mid] >= items[leftIndex])
                {
                    if ((searchItem < items[mid]) && (searchItem > items[leftIndex]))
                    {
                        return GetElementAtIndex(items, 0, mid - 1, searchItem);
                    }
                    else if ((searchItem > items[mid + 1]) && (searchItem < items[rightIndex]))
                    {
                       return GetElementAtIndex(items, mid + 1, rightIndex, searchItem);
                    }
                }

                return GetElementAtIndex(items, mid + 1, rightIndex, searchItem);
            }

            return -1;


        }
    }
}
