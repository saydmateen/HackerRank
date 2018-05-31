using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class TwoStacks
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem
        /// </summary>
        public static void Solution()
        {
            Queue<int> myQueue = new Queue<int>();
            int numOfInputs = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < numOfInputs; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                switch (input[0])
                {
                    case 1:
                        myQueue.Enqueue(input[1]);
                        break;
                    case 2:
                        myQueue.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine(myQueue.Peek());
                        break;
                }
            }
        }
    }
}