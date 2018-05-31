using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class DFSGrid
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-connected-cell-in-a-grid/problem
        /// </summary>
        public static void Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] nm = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] get = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                for (int k = 0; k < m; k++)
                {
                    nm[i, k] = get[k];    
                }
            }
        }
    }
}
