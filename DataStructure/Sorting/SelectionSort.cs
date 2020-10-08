using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Sorting
{
    public class SelectionSort
    {
        public int[] Sort(int[] items)
        {
            int length = items.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (items[i] > items[j])
                    {
                        int swap = items[i];
                        items[i] = items[j];
                        items[j] = swap;
                    }
                }
            }
            return items;
        }

       
    }
}
