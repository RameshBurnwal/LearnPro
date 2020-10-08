using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Sorting
{
    /// <summary>
    /// Implementation of Heap sort
    /// 
    /// INPUT :  { 12, 11, 13, 5, 6, 7 }
    /// Expected Output
    /// With MaxHeap :  { 13, 12, 11, 7, 6, 5 }
    /// With MinHeap : { 5, 6, 7, 11, 12, 13 }
    /// </summary>
    public class HeapSort
    {
        public int[] Sort(string type, int[] items)
        {
            int length = items.Length;

            //length/2-1 because we need to consider only nonleaf node
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                if (type.Equals("Max"))
                {
                    //Run this from down to up to heapify
                    Maxify(items, length, i);
                }
                else
                {
                    Minify(items, length, i);
                }
            }

            for (int i = length - 1; i >= 0; i--)
            {
                int temp = items[0];
                items[0] = items[i];
                items[i] = temp;

                if (type.Equals("Max"))
                {
                    //run this from top to bottom for heapify after removing the root node
                    Maxify(items, i, 0);
                }
                else
                {
                    Minify(items, i, 0);
                }


            }
            return items;
        }

        private void Minify(int[] items, int length, int i)
        {
            int minimum = i;
            //Tree node left and right child of a given node(i)
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && items[minimum] < items[left])
            {
                minimum = left;
            }
            if (right < length && items[minimum] < items[right])
            {
                minimum = right;
            }
            if (minimum != i)
            {
                //swap from the minimum of childern with root node
                int temp = items[0];
                items[0] = items[minimum];
                items[minimum] = temp;
                Minify(items, length, minimum);
            }
        }

        private void Maxify(int[] items, int length, int i)
        {
            int maximum = i;
            //Tree node left and right child of a given node(i)
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && items[maximum] > items[left])
            {
                maximum = left;
            }
            if (right < length && items[maximum] > items[right])
            {
                maximum = right;
            }
            if (maximum != i)
            {
                //swap from the maximum of childern with root node
                int temp = items[i];
                items[i] = items[maximum];
                items[maximum] = temp;
                Maxify(items, length, maximum);
            }

        }
    }
}
