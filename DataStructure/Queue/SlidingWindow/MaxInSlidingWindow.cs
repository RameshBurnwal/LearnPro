using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Queue.SlidingWindow
{
    /// <summary>
    /// With the given set of number and defined window size get the maximum number of each possible window
    /// INPUT : 1,4,45,6,0,19
    /// Window Size : 3
    /// Expected Outut : 45,45,45,19,19
    /// 
    /// 
    /// INPUT : 9,6,11,8,10,5,4,13,80,15
    /// Window Size : 3
    /// Expected Output : 11,11,11,10,10,13,80,80
    /// </summary>
    public class MaxInSlidingWindow
    {
        public int[] GetMaxInWindow(int[] Items, int windowSize)
        {
            int length = Items.Length;
            int start = 0;
            int[] temp = new int[Items.Length - windowSize + 1];
            while(start < temp.Length)
            {
                int maxNumber = 0;
                int i = 0;
                int t = start;
                while (i < windowSize)
                {
                    if (maxNumber < Items[t])
                    {
                        maxNumber = Items[t];
                    }                    
                    i++;
                    t++;
                }
                temp[start] = maxNumber;
                start++;
            }
            return temp;
        }




    }
}
