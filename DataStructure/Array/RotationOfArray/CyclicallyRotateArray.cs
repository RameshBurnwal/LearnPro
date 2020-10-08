using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.RotationOfArray
{
    public class CyclicallyRotateArray
    {
        //Input : {1, 2, 3, 4, 5} uptoindex : 0
        //Output : {5, 1, 2, 3, 4}

        //Input : {1, 2, 3, 4, 5} uptoindex : 1
        //Output : {4, 5, 1, 2, 3}
        public void RotateArray()
        {
            int[] items = { 1, 2, 3, 4, 5 };
            int uptoIndex = 1;
            int i = 0;
            while(i<= uptoIndex)
            {
                int temp = items[items.Length - 1];
                int j;
                for(j=items.Length-1;j>0;j--)
                {
                    items[j] = items[j - 1];
                }
                items[j] = temp;
                i++;
            }

            foreach (int k in items)
            {
                Console.WriteLine(k.ToString());
            }
        }
    }
}
