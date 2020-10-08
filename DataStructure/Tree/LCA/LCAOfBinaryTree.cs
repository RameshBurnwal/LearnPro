using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.LCA
{
    public class LCAOfBinaryTree
    {
        Node root = null;
       
        public LCAOfBinaryTree()
        {
            LBTree lbtree = new LBTree();
            int?[] nodes = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] nodes = { 1, 2, 2, 3, 4, 4, 3 };
            this.root = lbtree.CreateTreeWithArray(nodes, root, 0);
        }

        public int GetLCAOfTree(int node1, int node2)
        {
            DisplayTree();
            if (root == null)
                return -1;
            if (root.data == node1 && root.data == node2)
                return root.data ?? 0;
            Node lca = GetLCA(root, node1, node2);
            return lca.data ?? 0;
        }

        private Node GetLCA(Node root, int node1, int node2)
        {
            if (root == null)
                return null;
            if(root.data == node1 || root.data == node2)
            {
                return root;
            }
            Node LeftNode = GetLCA(root.Left, node1, node2);
            Node RightNode = GetLCA(root.Right, node1, node2);

            if (LeftNode != null && RightNode != null)
                return root;

            return (LeftNode != null) ? LeftNode : RightNode ;
        }

        private void DisplayTree()
        {
            LBTree tree = new LBTree();
            tree.TraverseInOrder(root);
        }
    }
}
