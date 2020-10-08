using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    //Input : {2,3,4,0,5,0,1,6}
    //Output : {2,3,4,5,1,6,0,0}
    public class MoveZeroAtEnd
    {
        public void MoveAllZeroAtEndWithoutSwap()
        {
            int[] items = { 2, 3, 4, 0, 5, 0, 1, 6 };
            int length = items.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                if (items[i].Equals(0))
                {
                    int temp = items[i];
                    int j = i;
                    while (j < length)
                    {
                        items[j] = items[j + 1];
                        j++;
                    }
                    items[length] = temp; 
                    length--;
                }
            }

            foreach (int i in items)
            {
                Console.WriteLine(i.ToString());
            }
        }



        //Input : {2,3,4,0,5,0,1,2}
        //Output : {2,3,4,2,5,1,0,0}

        public void MoveAllZeroAtEnd()
        {
            int[] items = { 2, 3, 4, 0, 5, 0, 1, 2 };
            int length = items.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                if (items[i].Equals(0))
                {
                    int temp = items[length];
                    items[length] = items[i];
                    items[i] = temp;
                    length--;
                }
            }

            foreach (int i in items)
            {
                Console.WriteLine(i.ToString());
            }


        }
    }
}
