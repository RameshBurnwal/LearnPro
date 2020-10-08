using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create and Traverse Tree Using Recursion");
            try
            {
                LBTree lbtree = new LBTree();
                Node root = lbtree.CreateTree();
                Console.WriteLine("InOrder");
                lbtree.TraverseInOrder(root);
                Console.WriteLine("PreOrder");
                lbtree.TraversePreOrder(root);
                Console.WriteLine("PostOrder");
                lbtree.TraversePostOrder(root);

            }
            catch (Exception ex)
            {
                string st = ex.Message;
            }
            Console.ReadKey();
        }
    }*/

    /// <summary>
    /// Tree and traversal with Recursion
    /// </summary>
    public class LBTree
    {
        public Node root;
        public Node CreateTree()
        {
            root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            root.Right.Left = new Node(6);
            root.Right.Right = new Node(7);
                   
            return root;
        }

        public Node CreateTreeWithArray(int?[] items, Node tree, int i)
        {
            if(i<items.Length)
            {
                Node temp = new Node(items[i]);
                tree = temp;
                tree.Left = CreateTreeWithArray(items, tree.Left, 2 * i + 1);
                tree.Right = CreateTreeWithArray(items, tree.Right, 2 * i + 2);
            }
            return tree;
        }

        public void TraverseInOrder(Node root)
        {
            if (root == null)
                return;
            TraverseInOrder(root.Left);
            Console.WriteLine(root.data);
            TraverseInOrder(root.Right);

        }

        public void TraversePreOrder(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.data);
            TraversePreOrder(root.Left);
            TraversePreOrder(root.Right);

        }

        public void TraversePostOrder(Node root)
        {
            if (root == null)
                return;
            TraversePostOrder(root.Left);
            TraversePostOrder(root.Right);
            Console.WriteLine(root.data);

        }
    }



    public class Node
    {
        public Node Left;
        public Node Right;
        public int? data;
        public Node(int? data)
        {
            this.Left = null;
            this.Right = null;
            this.data = data;
        }
    }
}
