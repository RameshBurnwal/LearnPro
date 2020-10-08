using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.Traverse
{
    /// <summary>
    /// InOrder Traverse of tree using stack
    /// </summary>
    public class InOrderTraverse
    {
        Node root = null;
        Stack<Node> st = null;
        public InOrderTraverse()
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
                    root = root.Left;
                }
                Node cur = st.Count > 0 ? st.Pop() : null;
                if (cur != null)
                {
                    if (cur.Right != null)
                        root = cur.Right;
                    Console.WriteLine(cur.data);
                }
            } while (st.Count >= 0);


        }
       

    }
}
