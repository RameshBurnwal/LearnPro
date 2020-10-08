using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.Traverse
{
    public class PostOrderTraverse
    {
        Node root = null;
        Stack<Node> st = null;
        public PostOrderTraverse()
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
                root = InsertInStack(root);
                Node cur = st.Count > 0 ? st.Pop() : null;
                Node validateRight = st.Count > 0 ? st.Peek() : null;
                if (cur.Right == validateRight)
                {
                    if (st.Count > 0)
                        st.Pop() ;                   
                    st.Push(cur);
                    if (validateRight.Right != null)
                    {
                        InsertInStack(validateRight);
                    }
                    else
                    Console.WriteLine(validateRight.data);
                }
                else
                    Console.WriteLine(cur.data);


            } while (st.Count > 0);


        }
        private Node InsertInStack(Node root)
        {
            while (root != null)
            {
                if (root.Right != null)
                {
                    st.Push(root.Right);
                }
                st.Push(root);
                root = root.Left;
            }
            return root;
        }
    }
}
