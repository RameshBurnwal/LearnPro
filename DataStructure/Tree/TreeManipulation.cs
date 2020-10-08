using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE
{
    class TreeManipulation
    {
        static void insert(Node temp, int key)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);

            // Do level order traversal until we find  
            // an empty place.  
            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.Left == null)
                {
                    temp.Left = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.Left);

                if (temp.Right == null)
                {
                    temp.Right = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.Right);
            }
        }
    }
}
