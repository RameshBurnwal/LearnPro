using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Array
{
    //Input:  arr[] = {1, 2, 3, 4, 5}
    //Steps : 1
    //Output: arr[] = {5, 1, 2, 3, 4}
    public static class CycleRotate
    {
        public static int[] RotateArray(int steps, int[] items)
        {
            if (items == null) return null;
            while (steps > 0)
            {
                int temp = items[^1]; //items[items.Length -1];
                for (int i = items.Length - 1; i > 0; i--)
                {
                    items[i] = items[i - 1];
                }

                items[0] = temp;
                steps--;
            }
            return items;
        }
    }
}
