using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    public class ArrayRotateLeft
    {
        public void RotateArray(int[] items, int noOfTimes)
        {
            int size = items.Length;
            int limit = size;
            int[] tempArray = new int[2 * size];
            for(int i=0; i<size;i++)
            {
                tempArray[i] = items[i];
            }
            for(int i=0; i<size;i++,limit++)
            {
                tempArray[limit] = items[i];
            }

            for(int i= noOfTimes%items.Length;i<(noOfTimes%items.Length + items.Length);i++ )
            {
                Console.WriteLine(tempArray[i].ToString());
            }

        }

        public void RotateArrayWithoutTempArray(int[] items, int noOfTimes)
        {
            int size = items.Length;
            int mod = size % noOfTimes;
            for(int i=0; i<size;i++)
            {
                Console.WriteLine(items[(i + mod) % size].ToString());
            }

        }
    }
}
