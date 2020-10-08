using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Queue.GetUglyNumber
{
    public class UglyNumber
    {
        public int GetUglyAt(int index)
        {
            int count = 0;
            int num = 1;
            count++;
            while (count < index)
            {                
                if (IsUgly(num++))
                    count++;
            }
            return 1;
        }

        private bool IsUgly(int v)
        {
            return false;
        }
    }
}
