using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataStructure.Array
{
    //Input = [1,2,3,4,5,6,7]
    //ToDigit = 2
    //Output = [3,4,5,6,7,1,2]
    public static class ArrayRotation
    {
        public static int[] RotateArray(int toDigit, int[] items)
        {
            if (items == null) return null;
            while (toDigit > 0)
            {
                int temp = items[0];
                for (int i = 1; i < items.Length; i++)
                {
                    items[i-1] = items[i];
                }

                //items[items.Length-1] = temp;
                items[^1] = temp;
                toDigit--;
            }

            return items;
        }

    }
}
