using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class RunningMedian
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-find-the-running-median/problem
        /// </summary>
        public static void Solution()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            for (int i = 0; i < size; i++)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int location = 0;
                if (i != 0)
                {
                    location = NarrowLocation(arr, val, 0, arr.Count - 1);
                }
                arr.Insert(location, val);
                float median = GetMedian(arr, i); 
                Console.WriteLine(String.Format("{0:0.0}" ,median));
            }
        }

        private static float GetMedian(List<int> numbers, int size) {
            bool even = (size+1) % 2 == 0;
            float median = even ? (numbers[size / 2] + numbers[(size / 2) + 1])/(float)2 : (numbers[size / 2])/(float)1;
            return median;
        }

        private static int NarrowLocation(List<int> arr, int val, int start, int end)
        {
            if (end <= start)
            {
                if (val >= arr[start])
                    return start + 1;
                else
                    return start;
            }

            int midpoint = (start+end)/2;

            if (arr[midpoint] < val)
                return NarrowLocation(arr, val, midpoint+1, end);
            else
                return NarrowLocation(arr, val, start, midpoint-1);
        }
    }
}