using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.MATRIX
{
    public class RotateMatrix
    {
        public void Rotate()
        {
            int[,] items = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int row = 3;
            int col = 3;
            Console.WriteLine("Print the matrix");
            for(int i=0; i< row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    Console.Write(items[i,j].ToString());
                }
                Console.WriteLine("");
            }

            int r = 0;
            int c = 0;
            while (r < row-1 && c < col-1)
            {
                int prev = items[r + 1, c];
                for (int i = 0; i < col; i++)
                {
                    int temp = items[r,i];
                    items[r,i] = prev;
                    prev = temp;
                }
                r++;
                for(int i=1; i<row;i++)
                {
                    int temp = items[i,col-1 ];
                    items[i, col-1] = prev;
                    prev = temp;
                }
                col--;
                for(int i=col; i>=0; i--)
                {
                    int temp = items[row-1, i];
                    items[row-1, i] = prev;
                    prev = temp;
                }
                row--;
                for (int i = row; i >= 0; i--)
                {
                    int temp = items[i, c];
                    items[i, c] = prev;
                    prev = temp;
                }
                c++;

            }

            Console.WriteLine("After Rearrange");
            Console.WriteLine("Print the matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(items[i, j].ToString());
                }
                Console.WriteLine("");
            }
        }
    }
}
