using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.MATRIX
{
    public class MaxElementInEachRow
    {
        public void GetMaxElement()
        {
            int row = 3;
            int col = 3;
            int[,] items = { { 3, 4, 1, 8 }, { 1, 4, 9, 11 }, { 76, 34, 21, 1 }, { 2, 1, 4, 5 } };
            for (int i = 0; i <= row; i++)
            {
                int max = items[i, 0];

                for (int j = 1; j <= col; j++)
                {
                    if (items[i, j] > max)
                    {
                        max = items[i, j];
                    }
                }

                Console.WriteLine($"maximum element at row {i} is {max}");
            }
         }
    }
}
