using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.ReArrange
{
    public class MoveAllZeroAtEnd
    {

        public void Rearrange()
        {
            int[] items = { 1, 2, 0, 4, 3, 0, 5, 0 };
            int size = items.Length - 1;
            for (int i=0; i<items.Length;i++)
            {
                if(items[i] == 0)
                {
                    int j = i;
                    while ( j < size)
                    {
                        items[j] = items[j + 1];
                        j++;
                    }
                    items[j] = 0;
                    size--;
                }
            }

            for (int i = 0; i < items.Length ; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
