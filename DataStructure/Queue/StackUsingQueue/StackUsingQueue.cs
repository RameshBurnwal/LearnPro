using System;
using System.Collections.Generic;
using System.Text;
using LBAssignments.Queue.CreateQueue;

namespace LBAssignments.Queue.StackUsingQueue
{
    public class StackUsingQueue
    {
        LBQueue queue = new LBQueue();
        LBQueue temp = new LBQueue();
        

        public StackUsingQueue()
        {
           
        }
        public void Push(int ele)
        {
            if (queue.IsFull())
                return;

            temp.Enqueue(ele);

            while(queue.IsEmpty())
            {
                temp.Enqueue(queue.Dequeue());
            }
            
            queue = temp;
            LBQueue.RemoveItems(temp);
        }

        public int Pop()
        {
            if (queue.IsEmpty())
                return -1;
            return queue.Dequeue();

        }
    }
}
