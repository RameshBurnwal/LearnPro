using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.ReverseArrayOfString
{
    public class ReverseArrayOfString
    {
        //Input
        string[] str = new string[] { "ram", "is", "coming", "to", "my", "home" };
        //Expected output
        //string[] str = { "home", "my", "to", "coming", "is", "ram" }

        public string[] Reverse()
        {
            string[] temp = new string[str.Length];
            int j = 0;
            for(int i=str.Length-1; i>=0;i--)
            {
                temp[j] = str[i];
                j++;
            }
            return temp;
        }

    }
}
