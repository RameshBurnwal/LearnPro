using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    //Input  arr[] = [10, 11, 12];
    //Given Index index[] = [1, 0, 2];
    //Output : [11, 10, 12]

    //INPUT [50, 40, 70, 60, 90]
    //INDEX [3,  0,  4,  1,  2]
    //Outpit [40, 60, 90, 50, 70]
    public class ReorderAccordingToIndex
    {
        public void ReorderWithTempArray()
        {
            int[] items = { 50, 40, 70, 60, 90 };
            int[] index = { 3, 0, 4, 1, 2 };
            int[] temp = new int[items.Length];
            for(int i=0;i<index.Length;i++)
            {
                temp[index[i]] = items[i];
            }

            foreach (int i in temp)
                Console.WriteLine(i.ToString());
        }

        public void ReorderWithoutTempArray()
        {
            int[] items = { 50, 40, 70, 60, 90 };
            int[] index = { 3, 0, 4, 1, 2 };
            
            
        }
    }
}
