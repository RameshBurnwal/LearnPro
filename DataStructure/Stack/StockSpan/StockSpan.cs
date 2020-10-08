using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack.StockSpan
{
    public class StockSpan 
    {
        int[] items = new int[] { 100, 80, 60, 70, 60, 75, 85 };
        int[] span;        
        public int[] GetSpanWithLoop()
        {
           
            span = new int[items.Length];
            span[0] = 1;
            for (int i=1;i<items.Length;i++)
            {
                int count = 1;
                for (int j = i; j >= 0; j--)
                    {
                        if (items[i] > items[j])
                        {
                            count++;                            
                        }
                        else
                            break;
                    }
                
                span[i] = count;
            }
            return span;
        }

        public int[] GetSpanWithStack()
        {
            LBStack<int> st = new LBStack<int>();
            span = new int[items.Length];
            st.Push(items[0]);
            span[0] = 1;
            for(int i=1; i<items.Length; i++)
            {
                if(items[i] < st.Peek())
                {
                    span[i] = i - (i - 1);
                    st.Push(items[i]);
                }
                else
                {
                    while(items[i] >= items[st.top] && !st.IsEmpty())
                    {
                        st.Pop();
                        span[i] = i - st.top;                        
                    }
                    st.Push(items[i]);
                }
            }
            return span;
        }

    }
}
