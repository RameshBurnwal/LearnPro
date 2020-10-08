using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Stack.CreateStack;

namespace LBAssignments.Stack.CreateQueueUsingStack
{
    public class QueueUsingStack
    {
        LBStack<int> st1 = new LBStack<int>();
        LBStack<int> st2 = new LBStack<int>();
        
        public void Enqueue(int ele)
        {
            while(!st1.IsEmpty())
            {
                st2.Push(st1.Pop());
            }
            st1.Push(ele);
            while(!st2.IsEmpty())
            {
                st1.Push(st2.Pop());
            }
        }

        public int Dequeue()
        {
            int ele = 0;
            if (st1.top == -1)
                return st1.top;
            ele = st1.Pop();
            return ele;
        }

        public void EnqueueOption2(int ele)
        {
            if (st1.IsFull())
                return;
            st1.Push(ele);
        }

        public int DequeueOption2()
        {
            if (st1.IsEmpty())
                return st1.top;
            while(!st1.IsEmpty())
            {
                st2.Push(st1.Pop());
            }
            int ele = st2.Pop();
            while (!st2.IsEmpty())
            {
                st1.Push(st2.Pop());
            }
            return ele;
        }

    }
}
