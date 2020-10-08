using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.MATRIX
{
    public class RowWithMaximumOnes
    {
        public void FindRow()
        {
            int row = 3;
            int col = 3;
            int rowFound = 0;
            
            int[,]  items = { { 0, 1, 1, 1 }, { 0, 1, 1, 1 }, { 1, 1, 1, 1 }, { 0, 0, 0, 1 } };
            for(int i=0;i<=row;i++)
            {
                while(col>=0)
                {
                    if (items[i, col] == 1)
                    {
                        col--;
                        rowFound = i;
                    }
                    else
                        break;
                    
                }
                
            }

            Console.WriteLine(rowFound);
        }
    }
}
