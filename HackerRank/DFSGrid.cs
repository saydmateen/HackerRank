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
            int max = 0;
            int[,] nm = new int[n, m];
            bool[,] visited = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] get = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                for (int k = 0; k < m; k++)
                {
                    nm[i, k] = get[k];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    if (nm[i, k] == 1)
                    {
                        int count = Search(nm, i, k, visited);
                        max = count > max ? count : max;
                    }
                }
            }
            Console.WriteLine(max);
        }

        static int Search(int[,] nm, int i, int k, bool[,] visited)
        {
            if (i < 0 || k < 0 || i >= nm.GetLength(0) || k >= nm.GetLength(1) || nm[i, k] == 0 || visited[i, k] == true)
            {
                return 0;
            }
            visited[i, k] = true;
            return 1 + 
                Search(nm, i+1, k, visited) + 
                Search(nm, i, k+1, visited) +
                Search(nm, i-1, k, visited) +
                Search(nm, i, k-1, visited) +
                Search(nm, i+1, k-1, visited) +
                Search(nm, i-1, k+1, visited) +
                Search(nm, i+1, k+1, visited) +
                Search(nm, i-1, k-1, visited);    
        }
    }
}
