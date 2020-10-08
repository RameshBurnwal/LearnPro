using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.Mirror
{

    /*
     static void Main(string[] args)
        {
            Console.WriteLine("Create and Traverse Tree Using Recursion");
            try
            {
                int?[] data = { 1, 3, 2, null, null, 5, 4 };
                CreateMirrorOfTree qs = new CreateMirrorOfTree(data);
                qs.CreateMirror();
                
                
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                string st = ex.InnerException.Message;
            }            
        }        
     */
    public class CreateMirrorOfTree
    {
        Node root = null;
        int?[] nodes;
        public CreateMirrorOfTree(int?[] data)
        {
            LBTree lbtree = new LBTree();
            nodes = data;
            this.root = lbtree.CreateTreeWithArray(nodes, root, 0);
        }

        public void CreateMirror()
        {
            if (root == null)
                return;
            Console.WriteLine("Tree In Order");
            DisplayTree();
            
            //Create Mirror of Tree
            Mirror(root);

            Console.WriteLine("Mirror Tree In Order");
            DisplayTree();
        }

        private void DisplayTree()
        {
            LBTree tree = new LBTree();
            tree.TraverseInOrder(root);
        }

        private Node Mirror(Node root)
        {
            if (root == null) return null;
            Node left = Mirror(root.Left);
            Node right = Mirror(root.Right);
            
            root.Left = right;
            root.Right = left;
            return root;
        }
    }
}
