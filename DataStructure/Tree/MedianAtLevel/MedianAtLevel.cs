using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.MedianAtLevel
{
    public class MedianAtLevel
    {
        Node root = null;
        Queue<Node> qu = null;
        public MedianAtLevel()
        {
            LBTree lbtree = new LBTree();
            this.root = lbtree.CreateTree();
            qu = new Queue<Node>();
        }
        public void Traverse()
        {
            if (root == null)
                return;
            Console.WriteLine(root.data);
            InsertInQueue(root);
            qu.Enqueue(null);
            int sum = 0;
            int count = 0;
            while (root != null && qu.Count > 0)
            {
                
                Node cur = qu.Dequeue();
                if (cur != null)
                {
                    sum = sum + cur.data ?? 0;
                    count++;
                }
                if (cur == null && qu.Count >= 0)
                {
                    Console.WriteLine("Average at level " + Convert.ToString(Math.Floor(Convert.ToDouble(sum / count))));
                    sum = 0;
                    count = 0;
                    if (qu.Count > 0)
                    {
                        qu.Enqueue(null);
                    }
                }
                else if (cur != null)
                {
                    Console.Write(cur.data);
                    InsertInQueue(cur);
                }
            }
        }

        private void InsertInQueue(Node root)
        {
            if (root.Left != null)
                qu.Enqueue(root.Left);
            if (root.Right != null)
                qu.Enqueue(root.Right);
        }
    }
}
