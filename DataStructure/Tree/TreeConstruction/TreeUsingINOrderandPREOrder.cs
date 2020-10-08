using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.TREE.TreeConstruction
{
    public class TreeUsingINOrderandPREOrder
    {
        int[] Inorder = { 4,2,1,5,3 };
        int[] PreOrder = { 1, 2, 4, 5, 3 };
        int rootIndex;

        public Node CreateTree()
        {
            if (Inorder == null)
                return null;
            if (Inorder.Length == 1)
                return new Node(Inorder[0]);
           
            Node Tree = ConstructTree(Inorder, PreOrder, 0, Inorder.Length-1);
            LBTree t = new LBTree();
            t.TraverseInOrder(Tree);
            return Tree;

        }

       
        private Node ConstructTree(int[] inOrderData , int[] preOrderData, int strIndex, int lstIndex )
        {
            int root = 0;
            if (strIndex > lstIndex)
                return null;            
            root = preOrderData[rootIndex++];                
            
            Node rootNode = new Node(root);
            if (strIndex == lstIndex)
            {
                return rootNode;
            }

            int Index = SearchIndex(inOrderData,strIndex, lstIndex, root);
            
            rootNode.Left = ConstructTree(inOrderData, preOrderData, strIndex, Index-1);
            rootNode.Right = ConstructTree(inOrderData, preOrderData, Index + 1, lstIndex);
            
            return rootNode;
           
        }

        private int SearchIndex(int[] inOrderData,int start, int end, int root)
        {
            int index = start;
            for(; index<end;index++)
            {
                if (inOrderData[index].Equals(root))
                    break;
               
            }
            return index;
            
        }
    }
}
