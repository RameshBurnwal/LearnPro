using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.PrintAncestorOfTree
{
    public class PrintAncestorOfNode
    {
        Node root = null;

        public PrintAncestorOfNode()
        {
            LBTree lbtree = new LBTree();
            int?[] nodes = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] nodes = { 1, 2, 2, 3, 4, 4, 3 };
            this.root = lbtree.CreateTreeWithArray(nodes, root, 0);
        }

        public int[] GetAncestor(int node)
        {
            if (root == null)
                return null;
            List<int> AllAncestor = new List<int>(5);

            AllAncestorData(root, node, AllAncestor);
            return AllAncestor.ToArray();
        }

        private bool AllAncestorData(Node root, int node, List<int> ancestor)
        {
            if (root == null) return false;

            if (root.data == node)
                return true;
           
            if (AllAncestorData(root.Left, node, ancestor) || AllAncestorData(root.Right, node, ancestor))
            {
                ancestor.Add(root.data ?? 0);
                return true;
            }
            return false;
        }
    }
}
