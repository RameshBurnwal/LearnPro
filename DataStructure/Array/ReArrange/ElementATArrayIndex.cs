using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.ReArrange
{
    public class ElementATArrayIndex
    {
        public void Rearrage()
        {
            int[] arr = { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };
            int size = arr.Length;
            for(int i=0;i<size;i++)
            {
                if(arr[i] >0 && arr[i] != i)
                {
                    int temp = arr[arr[i]];
                    arr[arr[i]] = arr[i];
                    arr[i] = temp;
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }

        }

    }
}
