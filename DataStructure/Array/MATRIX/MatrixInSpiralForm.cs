using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.MATRIX
{
    public class MatrixInSpiralForm
    {
        public void GetSpiral()
        {
            int row = 3;
            int col = 3;
            int r = 0;
            int c = 0;
            int[,] items = { { 1, 2, 3, 4, }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };


            while (c <= col && r <= row)
            {
                for (int i = 0; i <= col; i++)
                {
                    Console.WriteLine(items[r, i]);
                }
                r++;
                for (int i = r; i <= row; i++)
                {
                    Console.WriteLine(items[i, col]);
                }
                col--;
                if (r < row)
                {
                    for (int i = col; i >= c; i--)
                    {
                        Console.WriteLine(items[row, i]);
                    }
                    row--;
                }

                if (c < col)
                {
                    for (int i = row; i > r; i--)
                    {
                        Console.WriteLine(items[i, c]);
                    }
                    c++;
                }
            }
            Console.WriteLine("Print the matrix");
            
        }
    }
}
