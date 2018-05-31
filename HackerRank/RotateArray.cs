using System;

namespace HackerRank
{
    class RotateArray
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
        /// </summary>
        public static void Solution()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int length = Convert.ToInt32(tokens[0]); 
            int rotations = Convert.ToInt32(tokens[1]);

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int whereToBegin = rotations % length;

            for (int i = 0; i < length; i++)
            {
                var index = (whereToBegin + i) % length;
                Console.Write(input[index] + " ");
            }
        }
    }
}
