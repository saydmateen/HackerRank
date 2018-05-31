using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Anagram
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
        /// </summary>        
        public static void Solution()
        {
            var inputOne = new List<char>(Console.ReadLine().ToCharArray());
            var inputTwo = new List<char>(Console.ReadLine().ToCharArray());
            int changesNeeded = 0;
          
            for(int i=inputTwo.Count-1; i>=0; i--)
            {
                if (inputOne.Contains(inputTwo[i]))
                {
                    inputOne.Remove(inputTwo[i]);
                    inputTwo.RemoveAt(i);
                }
            }

            changesNeeded = inputOne.Count + inputTwo.Count;
            Console.WriteLine(changesNeeded);
        }
    }
}
