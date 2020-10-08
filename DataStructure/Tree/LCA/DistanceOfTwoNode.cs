using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.LCA
{
    /*
     static void Main(string[] args)
        {
            Console.WriteLine("Create and Traverse Tree Using Recursion");
            try
            {
                DistanceOfTwoNode qs = new DistanceOfTwoNode();
                int data = qs.GetDistanceOfNodes(8,5);
                
                
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                string st = ex.InnerException.Message;
            }            
        }      
     */
    public class DistanceOfTwoNode
    {
        Node root = null;

        public DistanceOfTwoNode()
        {
            LBTree lbtree = new LBTree();
            int?[] nodes = { 1, 2, 3, 4, 5, 6, 7 ,null,null,null,null,8};
            //int[] nodes = { 1, 2, 2, 3, 4, 4, 3 };
            this.root = lbtree.CreateTreeWithArray(nodes, root, 0);
        }

        public int GetDistanceOfNodes(int node1, int node2)
        {
            DisplayTree();
            if (root == null)
                return -1;
            if (root.data == node1 && root.data == node2)
                return root.data ?? 0;
            Node lca = GetLCA(root, node1, node2);
            int level = 0;
            int traverse1 = GetDistanceOfNodeFromLCA(lca, node1, level);
            int traverse2 = GetDistanceOfNodeFromLCA(lca, node2, level);
            return traverse1 + traverse2;
        }

        private int GetDistanceOfNodeFromLCA(Node lca, int node, int level)
        {
            if (lca == null)
                return -1;
            if (lca.data == node)
                return level;
            
            int distance = GetDistanceOfNodeFromLCA(lca.Left, node, level+1);
            if (distance == -1)
                distance = GetDistanceOfNodeFromLCA(lca.Right, node, level+1);
            
            return distance;           

        }

        private Node GetLCA(Node root, int node1, int node2)
        {
            if (root == null)
                return null;
            if (root.data == node1 || root.data == node2)
            {
                return root;
            }
            Node LeftNode = GetLCA(root.Left, node1, node2);
            Node RightNode = GetLCA(root.Right, node1, node2);

            if (LeftNode != null && RightNode != null)
                return root;

            return (LeftNode != null) ? LeftNode : RightNode;
        }

        private void DisplayTree()
        {
            LBTree tree = new LBTree();
            tree.TraverseInOrder(root);
        }
    }
}
