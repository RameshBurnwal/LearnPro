using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Sorting
{
    public class BubbleSort
    {
        public int[] Sort(int[] items)
        {
            int length = items.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length-i-1; j++)
                {
                    if (items[j] > items[j+1])
                    {
                        int swap = items[j];
                        items[j] = items[j+1];
                        items[j+1] = swap;
                    }
                }
            }
            return items;
        }
    }
}
