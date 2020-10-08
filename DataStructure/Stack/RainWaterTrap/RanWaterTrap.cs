using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack.RainWaterTrap
{
    public class RanWaterTrap
    {
        int[] items = new int[] { 2, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1, 3 };
        LBStack<int> st = new LBStack<int>();
        public int GetMaxWaterTrapped()
        {
            int i = 0;
            int total = 0;
            while(i<items.Length)
            {
                if (st.IsEmpty() || items[i] < items[st.Peek()])
                    st.Push(i);
                else 
                {
                    while (!st.IsEmpty() && items[i] >= items[st.Peek()])
                    {
                        int top = st.Pop();
                        int height = Math.Min(items[i], items[st.Peek()]) - items[top];
                        int width = st.IsEmpty() ? 0 : i - 1 - st.Peek();
                        total = total + (height * width);
                    }
                }
                i++;
            }
            return total;


        }
    }
}
