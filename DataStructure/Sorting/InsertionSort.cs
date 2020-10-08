using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Sorting
{
    public class InsertionSort
    {
        public int[] Sort(int[] items)
        {
            int length = items.Length;
            for (int i = 1; i < length; i++)
            {
                int ele = items[i];
                int j = i - 1;
                while(j>=0 && ele < items[j])
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j+1] = ele;
               
            }
            return items;
        }        
    }
}
