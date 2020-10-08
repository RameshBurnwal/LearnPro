using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Stack.CreateStack
{
    public class LBStack<T>
    {
        public int top;
        private int size;
        private T[] stack = null;
        public LBStack(int size = 10)
        {
            this.size = size;
            top = -1;
            stack = new T[size];
        }
        public void Push(T ele)
        {
            try
            {
                if (IsFull())
                    throw new Exception("Stack overflow");
                stack[++top] = ele;
            }
            catch(Exception ex)
            {
                              
            }
        }
        public T Pop()
        {
            T item = default(T);
            try
            {
                if(IsEmpty())
                {
                    throw new Exception("Stack Underflow");
                }
                item = stack[top--];
                return item;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return item;
                
            }
        }
        public T Peek()
        {
            T item = default(T);
            try
            {
                if (IsEmpty())
                {
                    throw new Exception("Stack Underflow");
                }
                item = stack[top];
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return item;
            }
        }
        public bool IsFull()
        {
            return top == (size - 1) ? true : false;
        }
        public bool IsEmpty()
        {
            return top == -1 ? true : false;
        }
        public int SizeofStack()
        {
            return size;
        }
    }
}
