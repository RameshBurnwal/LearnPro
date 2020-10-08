using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack.HistogramArea
{
    public class HistogramArea
    {
        // public int[] items = new int[] { 6, 2, 5, 4, 5, 1, 6 };
        public int[] items = new int[] { 2, 3, 4, 8, 3, 2, 4 ,5};
        public int max;
        public int GetMaxArea()
        {
            for(int i=0; i<items.Length; i++)
            {
                int area = 0;
                int j = i; int k= i;
                int m = 0;
                while (m<items.Length)
                {                    
                    if (j>=0 && items[i] <= items[j])
                    {
                        area = area + items[i];
                        j = j - 1;
                    }
                    else
                    {
                        //Here we are checking with length-2 as we are calculating from k+1 as same index already calculated in above part
                        if (k<= items.Length-2 && items[i] <= items[k+1])
                        {
                            area = area + items[i];
                            k = k + 1;
                        }
                    }
                    m++;
                }
                max = max < area ? area : max;
            }
            return max;
        }

        public int GetMaxWithStack()
        {
            int i = 0;
            LBStack<int> st = new LBStack<int>();
            
            while (i<items.Length)
            {
                if(items[i] > items[st.Peek()] || st.IsEmpty())
                {
                    st.Push(i);
                }
                else
                {                   
                    while (!st.IsEmpty() && items[i] <= items[st.Peek()])
                    {
                        calculateArea(items, st, i);
                    }
                    st.Push(i);
                }
                i++;
            }

            while(!st.IsEmpty())
            {
                calculateArea(items, st, i);
            }

            return max;
        }

        private void calculateArea(int[] items, LBStack<int> st, int index)
        {           
            int pop_index = st.Pop();
            int lower_bound = st.IsEmpty() ? -1 : st.Peek();
            int area = items[pop_index] * ((index - 1) - lower_bound);
            UpdateArea(area);

        }

        private void UpdateArea(int area)
        {
           max = max < area ? area : max;
        }
    }    
}
