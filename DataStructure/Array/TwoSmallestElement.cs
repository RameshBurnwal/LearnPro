using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    public class TwoSmallestElement
    {
        public void GetSmallestElements()
        {
            int[] items = { 4, 16, 12, 5, 2 };
            int first = items[0];
            int second = items[1];
            if(second < first )
            {
                first = second;
                second = items[0];
            }
            for(int i = 2; i<items.Length;i++)
            {
                if (items[i] < first)
                {
                    second = first;
                    first = items[i];
                }
                else if (items[i] >= first && items[i] < second)
                {
                    second = items[i];
                }

            }
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"first element {first} Second element {second}");
            

        }
    }
}
