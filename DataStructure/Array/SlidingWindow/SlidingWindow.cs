using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.SlidingWindow
{
    public class SlidingWindow
    {
        //int[] items = { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
        //int elementRange = 4;
        int[] items = { 100, 200, 300, 400 };
        int elementRange = 2;
        //Brute Force for maximum sum

        public int GetMaximumSum()
        {
            int maxSum = 0;
            for(int i=0;i<items.Length-elementRange +1;i++)
            {
                int sum = 0;
                int j = i;
                int count = 0;
                while(count<elementRange && j<items.Length)
                {
                    sum = sum + items[j];
                    count++;j++;
                }
                maxSum = maxSum < sum ? sum : maxSum;
            }
            return maxSum;
        }

        //Using Adding and Deleting items

        public int GetMaxSumOption2()
        {
            int maxSum = 0;
            int j = 0; int sum = 0;
            while(j<elementRange)
            {
                sum = sum + items[j];
                j++;
            }
            maxSum = sum;
            for(int i=0;i<items.Length-elementRange;i++)
            {
                sum = sum - items[i] + items[j];
                maxSum = maxSum > sum ? maxSum : sum;
                j++;
            }
            
            return maxSum;
        }

    }
}
