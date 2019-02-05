using System;
using System.Collections.Generic;
namespace MergeSortWeek1
{
    class MergeSort
    {
         void MergeSortt(int[] A)
        {
            int len = A.Length;
            int mid = len / 2;
            if (len < 2)
                return;
            int[] left = new int[mid];
            int[] right = new int[len - mid];
            for (int c = 0; c<= mid - 1;c++)
            {
                left[c] = A[c];
            }
            for (int c= mid; c<= len-1;c++)
            {
                right[c-mid] = A[c];
            }
            MergeSortt(left);
            MergeSortt(right);
            Merge(left, right, A);
        }
         void Merge(int[] l,int[] r,int[] A)
        {
            int lenL = l.Length;
            int lenR = r.Length;
            int i = 0, j = 0, k = 0;
            while(i<lenL && j<lenR)
            {
                if (l[i] <= r[j])
                    A[k++] = l[i++];
                else
                    A[k++] = r[j++];

            }
            while(i<lenL)
            {
                A[k++] = l[i++];
        
            }
            while(j<lenR)
            {
                A[k++] = r[j++];
            }

        }
            static void Main(string[] args)
        {
                try
                {
            MergeSort obj = new MergeSort();
            int[] A = { 23, 11, 45, 2, 67, 89, 32 };

            Console.WriteLine("Array in inserted order is :");
            foreach (var element in A)
            {
                Console.Write(element + "   ");
            }
            obj.MergeSortt(A);
            Console.WriteLine("\nArray in Sorted order is :");
            foreach (var element in A)
            {
                Console.Write(element + "   ");
            }
                }
                Catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            Console.ReadKey();
        }


    }
    
}
