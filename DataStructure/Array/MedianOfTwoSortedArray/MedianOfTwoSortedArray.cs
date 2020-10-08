using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.MedianOfTwoSortedArray
{
    class MedianOfTwoSortedArray
    {
        public static int[] arr1 = { 1, 2 };
        static int[] arr2 = { 3, 4 };
        //Median should be (2+3)/2 = 2.5

        int[] arr3 = { 1, 3 };
        int[] arr4 = { 2 };

        //Median should be 2.0


        int number = GetMedian(arr1,arr2);

        private static int GetMedian(int[] arr1, int[] arr2)
        {
            int median = 0;
            int count1 = arr1.Length;
            int count2 = arr2.Length;
            int average = (count1 + count2) / 2;
            if(average>count1)
            {
                median = (arr2[average] + arr2[average + 1]) / 2;
            }
            else if(average > count2)
                median = (arr1[average] + arr1[average + 1]) / 2;
            else if (average == count2 && average == count1)
                median = (arr1[average] + arr2[average + 1]) / 2;

            return median;

        }
    }


}
