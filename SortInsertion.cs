using System;
using System.Collections.Generic;
namespace SortInsertionWeek1
{
    class Program
    {
            void InsertionSortt(List<int> A, int n)
            {
                int value, hole;
                for (int i = 1; i <= n - 1; i++)
                {
                    value = A[i];
                    hole = i;
                    while (hole > 0 && A[hole - 1] > value)
                    {
                        A[hole] = A[hole - 1];
                        hole = hole - 1;
                    }
                    A[hole] = value;
                }

            }
            static void Main(string[] args)
            {
                Program obj = new Program();
                List<int> l = new List<int>();
                Console.WriteLine("Enter Size :");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter " + n + " Values :");
                for (int i = 0; i < n; i++)
                {
                    l.Add(Convert.ToInt32(Console.ReadLine()));
                }
                Console.WriteLine("List in inserted order is :");
                foreach (var element in l)
                {
                    Console.Write(element + "   ");
                }
                obj.InsertionSortt(l, n);
                Console.WriteLine("\nList in Sorted order is :");
                foreach (var element in l)
                {
                    Console.Write(element + "   ");
                }
                Console.ReadKey();
            }
        }
    }


