using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack
{
    public class ReverseStackUsingRecursion
    {

        public void ReverseStack()
        {
            LBStack<int> st = new LBStack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            int element = st.top;
            Console.WriteLine("Stack elements...");
            //while(st.top != -1)
            //{
            //    Console.WriteLine($"Stack Element is {st.Pop()}");
            //}

            Console.WriteLine("Reverse the stack");
            CallReverse(st,0, element);
            while (st.top != -1)
            {
                Console.WriteLine($"Stack Element is {st.Pop()}");
            }
        }

        private void CallReverse(LBStack<int> st, int count, int element)
        {
            
            if (element == count)
                return;

            st.Pop();
           
            CallReverse(st, ++count, element);
            st.Push(st.top);
        }
    }
}
