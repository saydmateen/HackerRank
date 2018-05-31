using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class BubbleSort
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-bubble-sort/problem
        /// </summary>
        public static void Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int swap = 0;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n-i-1; k++)
                {
                    if (arr[k] > arr[k+1])
                    {
                        swap++;
                        int temp = arr[k];
                        arr[k] = arr[k+1];
                        arr[k+1] = temp;
                    }
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.", swap);
            Console.WriteLine("First Element: {0}", arr[0]);
            Console.WriteLine("Last Element: {0}", arr[arr.Length - 1]);
        }
    }
}
