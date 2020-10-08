using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array
{
    //INPUT : {1,2,3,4,5,6,7}
    //OUTPUT : {7,6,5,4,3,2,1}
    public class ReverseAnArray
    {
        public void GetReverse()
        {
            int[] items = { 1, 2, 3, 4, 5, 6, 7 ,8};
            int lenght = items.Length - 1;
            for (int i = 0; i <= lenght / 2; i++)
            {
                int temp = items[lenght];
                items[lenght] = items[i];
                items[i] = temp;
                lenght--;
            }
            foreach (int i in items)
                Console.WriteLine(i.ToString());
        }
    }
}
