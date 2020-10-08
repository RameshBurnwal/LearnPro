using LBAssignments.TREE.Traverse;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Sorting
{
    /*
     static void Main(string[] args)
        {
           try
            {
                int[] arr = { 10, 80, 30, 90, 40, 50, 70,60,20 };
                QuickSort qs = new QuickSort();
                arr = qs.Sort(arr, 0, arr.Length-1);

                foreach(int item in arr)
                {
                    Console.WriteLine(item.ToString());
                }
                
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                string st = ex.InnerException.Message;
            }            
        }      

      */
    public static class MergeSort
    {
        public static int[] Sort(int[] items)
        {
            int length = items.Length;
            int[] itemsData = MergeSortMethod(items, 0, length);
            return itemsData;
        }
       
        private static int[] MergeSortMethod(int[] items, int low, int high)
        {
            if(low <= high)
            {
                int mid = (low + high) / 2;
                MergeSortMethod(items, low, mid);
                MergeSortMethod(items, mid + 1, high);
                CompareAndMerge(items, low, mid, high);
            }

            return items;
        }

        private static void CompareAndMerge(int[] items, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;
            int[] tempArr1 = new int[n1];
            int[] tempArr2 = new int[n2];
            for(int i=0; i<n1;i++)
            {
                tempArr1[i] = items[low+i];
            }
            for (int i = 0; i < n2; i++)
            {
                tempArr2[i] = items[mid+1+i];
            }
            
           // TODO :: Write code for comparision and swap
        }
    

        private static void Swap(int[] items, int low, int high)
        {
            int temp = items[low];
            items[low] = items[high];
            items[high] = temp;
        }

    }
}
