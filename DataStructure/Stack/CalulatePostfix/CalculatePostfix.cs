using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack.CalulatePostfix
{
    public class CalculatePostfix
    {
        public int Calculate(string str)
        {
            int value = 0;
            LBStack<int> st = new LBStack<int>();
            foreach(char c in str)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    int c1 = st.Pop();
                    int c2 = st.Pop();
                    switch(c)
                    {
                        case '+': value = c2 + c1;break;
                        case '-': value = c2-c1; break;
                        case '*': value = c2*c1; break;
                        case '/': value = c2/c1; break;
                        default: break;
                    }
                    st.Push(value);
                }
                else
                    st.Push(Convert.ToInt32(c.ToString()));

            }
            return value;
        }
    }
}
