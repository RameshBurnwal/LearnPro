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
                TreeSelfMirror qs = new TreeSelfMirror();
                bool data = qs.ValidateIsSelfMirror();
                
                
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                string st = ex.InnerException.Message;
            }            
        }     
     */
    public class TreeValidateSelfMirror
    {
        Node root = null;
        public TreeValidateSelfMirror()
        {
            LBTree lbtree = new LBTree();
            int?[] nodes = { 1, 2, 2,0, 3,0,3 };
            //int[] nodes = { 1, 2, 2, 3, 4, 4, 3 };
            this.root = lbtree.CreateTreeWithArray(nodes, root, 0);
        }

        public bool ValidateIsSelfMirror()
        {
            if (root == null)
                return true;
             return Validate(root.Left, root.Right);
        }

        private bool Validate(Node left, Node right)
        {           
            if (left == null && right == null)
            {
                return true;
            }
            else
            {
                if (left.data == right.data)
                {
                    if (left.Left != null && right.Right != null)
                    {
                        Validate(left.Left, right.Right);
                    }
                    if (left.Right != null && right.Left != null)
                    {
                        Validate(left.Right, right.Left);
                    }
                   
                }
                else
                    return false;

            }
            return true;
            
        }
    }
}
