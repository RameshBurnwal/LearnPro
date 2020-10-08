using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Queue.SmallestSubarrayOfMaxSum
{
    /// <summary>
    /// With the given array find the length of smallest subarray which gives max sum of given number
    /// 
    /// INPUT : {1, 4, 45, 6, 0, 19}
    /// Number : 51
    /// OUTPUT : 3
    /// </summary>
    public class SmallestSubArray
    {
        public int GetSubArray(int[] Item, int max)
        {
            int length = Item.Length;
            int sum = 0;
            int min_length = length;
            int start = 0;
            int end = 0;
            while(end < length)
            {
                while(sum <= max && end <= length)
                {
                    sum = sum + Item[end++];                    
                   
                }
                while(sum > max && start < length)
                {
                    if (min_length > (end - start))
                        min_length = end - start;

                    sum = sum - Item[start++];
                   
                }
                
            }
            return min_length;
        }
    }
}
