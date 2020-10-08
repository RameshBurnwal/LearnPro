using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack.NextGreaterElement
{
    public class NextGreaterElement
    {

        int[] items = new int[] { 13, 7, 6, 12 };
        Dictionary<int, int> data = new Dictionary<int, int>();
        int max;

        public IDictionary<int,int> GetNextGreaterElement()
        {
            LBStack<int> st = new LBStack<int>();
            foreach (int i in items)
                st.Push(i);
            while (!st.IsEmpty())
            {
                int item = st.Peek();
                if (st.top == 0 || st.top == items.Length - 1)
                {
                    st.Pop();
                    data.Add(item, -1);
                }
                else
                {
                    st.Pop();
                    data.Add(item, max);
                }
                max = item < max ? max : item;
            }

            return data;
        }

    }
}
