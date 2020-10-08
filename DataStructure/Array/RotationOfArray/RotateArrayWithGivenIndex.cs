using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.RotationOfArray
{
    //INPUT : {1,2,3,4,5,6,7} rotateuptoIndex : 1
    //OUTPUT : {3,4,5,6,7,1,2}
    public class RotateArrayWithGivenIndex
    {
        public void RotatewithGivenIndex()
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7 };
            int rotatetoIndex = 1;
            int i = 0;
            while (i <= rotatetoIndex)
            {
                int temp = items[0];
                int j = 1;
                for (; j < items.Length; j++)
                {
                    items[j - 1] = items[j];

                }
                items[j - 1] = temp;
                i++;
            }
            foreach (int k in items)
            {
                Console.WriteLine(k.ToString());
            }
        }
        public void RotatewithGivenPlace()
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7 };
            int rotateuptoPlace = 4;
            int i = 0;
            while(i< rotateuptoPlace)
            {
                int temp = items[0];
                int j = 1;
                for(; j<items.Length;j++)
                {
                    items[j - 1] = items[j];

                }
                items[j-1] = temp;
                i++;
            }
            foreach(int k in items)
            {
                Console.WriteLine(k.ToString());
            }
        }
    }
}
