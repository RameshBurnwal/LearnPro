using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.LCA
{
    public class LCAWithOrderN_BruteForce
    {
        Node root = null;
        public LCAWithOrderN_BruteForce()
        {
            LBTree lbtree = new LBTree();
            int?[] nodes = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] nodes = { 1, 2, 2, 3, 4, 4, 3 };
            this.root = lbtree.CreateTreeWithArray(nodes, root, 0);
        }

        public int GetLCAOfTree(int node1, int node2)
        {
            FirstDisplayTree();
            List<int?> traverse1 = new List<int?>();
            List<int?> traverse2 = new List<int?>();
            traverse1.Clear();
            traverse2.Clear();
            IsNodeFound(root, node1, traverse1);
            IsNodeFound(root, node2, traverse2);
            int index = 0;
            for(index = 0;index<traverse1.Count && index < traverse2.Count; index++ )
            {
                if(!(traverse1[index].Equals(traverse2[index])))
                {
                    break;
                }
            }
            return traverse1[index - 1] ?? 0;            
        }

        private void FirstDisplayTree()
        {
            LBTree tree = new LBTree();
            tree.TraverseInOrder(root);
        }

        private bool IsNodeFound(Node root, int node, List<int?> traverse)
        {
            if (root == null)
                return false;
            traverse.Add(root.data);
            if (root.data == node)
                return true;
            if (root.Left != null && IsNodeFound(root.Left, node, traverse))
            {
                return true;
            }
            if (root.Right != null && IsNodeFound(root.Right, node, traverse))
            {
                return true;
            }
            traverse.Remove(traverse.Count - 1);
            return false;
        }
    }
}
