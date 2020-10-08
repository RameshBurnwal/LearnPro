using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    public class LargestSumContiguousSubArray
    {
        public void LargestSum()
        {
            int[] items = { -2, -3, 4, -1, -2, 1, 5, -3 };
            int max_so_far = items[0];
            int current_Max = items[0];
            for(int i=1;i<items.Length;i++)
            {
                current_Max = Math.Max(items[i], current_Max + items[i]);
                max_so_far = Math.Max(max_so_far, current_Max);
            }
            Console.WriteLine( max_so_far);
        }
    }
}
