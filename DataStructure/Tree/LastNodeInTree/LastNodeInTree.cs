using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.LastNodeInTree
{
    public class LastNodeInTree
    {
        Node root = null;
        Queue<Node> qu = null;
        public LastNodeInTree()
        {
            LBTree lbtree = new LBTree();
            this.root = lbtree.CreateTree();
            qu = new Queue<Node>();
        }
        public void Traverse()
        {
            if (root == null)
                return;
            Console.Write(root.data);
            InsertInQueue(root);
            while (root != null && qu.Count > 0)
            {
                Node cur = qu.Dequeue();
                Console.Write(cur.data);
                InsertInQueue(cur);
                if (cur.Left == null && cur.Right == null && qu.Count == 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Last Element is " + cur.data.ToString());

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
