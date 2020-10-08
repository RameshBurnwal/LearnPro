using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.Traverse
{
    public class LevelOrderTraverseWithSeparateLine
    {
        Node root = null;
        Queue<Node> qu = null;
        public LevelOrderTraverseWithSeparateLine()
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
            while (root != null && qu.Count > 0)
            {
                Node cur = qu.Dequeue();
                if (cur == null && qu.Count >0)
                {
                    Console.WriteLine(" ");
                    qu.Enqueue(null);
                }
                else if(cur != null)
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
