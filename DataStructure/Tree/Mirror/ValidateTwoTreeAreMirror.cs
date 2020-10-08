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
                ValidateTwoTreeAreMirror qs = new ValidateTwoTreeAreMirror();
                bool data = qs.ValidateTwoTreeIsMirror();
                
                
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                string st = ex.InnerException.Message;
            }            
        }        
     */
    public class ValidateTwoTreeAreMirror
    {
        public bool ValidateTwoTreeIsMirror()
        {
            int?[] data1 = { 1, 3, 2, null, null, 5, 4 };
            int?[] data2 = { 1, 2, 3, 4, 5, null, null };
            Node tree1 = CreateTree(data1);
            Node tree2 = CreateTree(data2);
            if (tree1.data == tree2.data)
            {
                bool areMirror = Validate(tree1, tree2);
                return areMirror;
            }
            else return false;
            
        }

        private bool Validate(Node tree1, Node tree2)
        {
            if (tree1 == null && tree2 == null)
            {
                return true;
            }
            else
            {
                if (tree1.data == tree2.data)
                {
                    if (tree1.Left != null && tree2.Right != null)
                    {
                        Validate(tree1.Left, tree2.Right);
                    }
                    if (tree1.Right != null && tree2.Left != null)
                    {
                        Validate(tree1.Right, tree2.Left);
                    }

                }
                else
                    return false;

            }
            return true;
        }

        private Node CreateTree(int?[] data)
        {
            LBTree tree = new LBTree();
            return tree.CreateTreeWithArray(data, null, 0);
        }
    }
}
