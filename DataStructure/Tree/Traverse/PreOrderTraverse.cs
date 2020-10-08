using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.Traverse
{
    public class PreOrderTraverse
    {
        Node root = null;
        Stack<Node> st = null;
        public PreOrderTraverse()
        {
            LBTree lbtree = new LBTree();
            this.root = lbtree.CreateTree();
            st = new Stack<Node>();
        }
        public void Traverse()
        {
            if (root == null)
                return;

            do
            {
                while (root != null)
                {
                    st.Push(root);
                    Console.WriteLine(root.data);
                    root = root.Left;
                }

                Node cur = st.Count > 0 ? st.Peek() : null;

                if(st.Count > 0)
                    st.Pop();

                if (cur != null)
                {
                    if (cur.Right != null)
                        root = cur.Right;
                    
                }
            } while (st.Count >= 0);


        }

    }
}
