using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Array.ReverseArrayOfString
{
    public class ReverseString
    {
        //input
        string str = "my name is ramesh";
        //Expected output
        //"hsemar si eman ym"

        public string Reverse()
        {
            char[] ch = str.ToCharArray();
            string revstr = string.Empty;
            for(int i=ch.Length-1; i>=0; i--)
            {
                revstr = revstr + ch[i].ToString();
            }
            return revstr;
        }
    }
}
