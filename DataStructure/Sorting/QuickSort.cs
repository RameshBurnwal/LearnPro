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
    public class QuickSort 
    {       
        public int[] Sort(int[] arr, int low, int high)
        {
           if (low < high)
            {
                int Index = Partition(arr, low, high);
                Sort(arr, low, Index - 1);
                Sort(arr, Index+1, high);
            }
            return arr;
        }

        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int index = low - 1;
            for (int j = low; j < high ; j++)
            {
                if (arr[j] < pivot)
                {
                    index++;
                    Swap(arr, index, j);
                }
            }
            Swap(arr, index+1, high);
            return index+1;
        }
        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
