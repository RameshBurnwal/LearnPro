using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.LCA
{
    public class LCAOfBinarySearchTree
    {
        Node root = null;

        public LCAOfBinarySearchTree()
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
           
            if (node1 < root.data && node2 < root.data)
            {
                Node LeftNode = GetLCA(root.Left, node1, node2);
            }
            if (node1 > root.data && node2 > root.data)
            {
                Node LeftNode = GetLCA(root.Right, node1, node2);
            }
            return root;
        }

        private void DisplayTree()
        {
            LBTree tree = new LBTree();
            tree.TraverseInOrder(root);
        }
    }
}
