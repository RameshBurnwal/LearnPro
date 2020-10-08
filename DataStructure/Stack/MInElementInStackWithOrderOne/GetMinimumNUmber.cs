using System;
using System.Collections.Generic;
using LBAssignments.Stack.CreateStack;
using System.Text;

namespace LBAssignments.Stack.MInElementInStackWithOrderOne
{
    public class GetMinimumNUmber
    {
        private int top;
        private int min;
        private int size;
        private int[] Item = null;
        public GetMinimumNUmber(int size = 10)
        {
            top = -1;
            min = 0;
            this.size = size;
            Item = new int[10];
        }

        public void Push(int newItem)
        {
            try
            {
                if (top == size - 1)
                {
                    throw new Exception("Stack overflow");
                }                
                if(top == -1)
                {
                    Item[++top] = newItem;
                    min = newItem;
                }
                else if (newItem > min)
                {
                    Item[++top] = newItem;
                }
                else {
                    int data = 2 * newItem - min;
                    min = newItem;
                    Item[++top] = data;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Pop()
        {
            try
            {
                if (top == -1)
                    throw new Exception("Stack underflow");
                int popped = Item[top];
                top--;
                if (popped < min)
                {
                    min = 2 * min - popped;                  
                    
                }
                return popped;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }      

        public int Peek()
        {
            try {
                if (top == -1)
                    throw new Exception("Stack underflow");
                return Item[top];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int MinValue()
        {
            return min;
        }
    }
}
