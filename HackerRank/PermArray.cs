using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class PermArray
    {
        /// <summary>
        /// LeetCode Problem: https://leetcode.com/problems/k-inverse-pairs-array/description/
        /// </summary>
        public static void Solution()
        {
            int n = 3;
            int k = 0;
            int[] arr = Enumerable.Range(1, n).ToArray();
            int count = 0;
            GetPer(arr, 0, arr.Length - 1, ref count, k);
            Console.WriteLine($"Count: {count}");
        }
        private static void GetPer(int[] list, int b, int m, ref int count, int k)
        {
            if (b == m)
            {
                int kCount = 0;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    for (int j = i + 1; j < list.Length; j++)
                    {
                        if (list[i] > list[j])
                        {
                            kCount++;
                        }
                        if (kCount > k) break;
                    }
                    if (kCount > k) break;
                }
                if (kCount == k) count++;
            }
            else
            {
                for (int i = b; i <= m; i++)
                {
                    Swap(ref list[b], ref list[i]);
                    GetPer(list, b + 1, m, ref count, k);
                    Swap(ref list[b], ref list[i]);
                }
            }
        }
        private static void Swap(ref int a, ref int b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}
