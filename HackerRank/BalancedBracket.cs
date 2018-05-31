using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class BalancedBracket
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-balanced-brackets/problem
        /// </summary>
        public static void Solution()
        {
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                bool success = ProcessLine(Console.ReadLine().ToCharArray());
                Console.WriteLine(success ? "YES" : "NO");
            }
        }

        public static bool ProcessLine(char[] line)
        {
            Stack<char> brackets = new Stack<char>();
            foreach(char c in line)
            {
                if(c == '[' || c == '(' || c == '{')
                {
                    brackets.Push(c);
                }
                else
                {
                    if (brackets.Count == 0) return false;
                    char lastBracket = brackets.Pop();
                    bool valid = false;
                    switch (c)
                    {
                        case ']':
                            valid = lastBracket == '[';
                            break;
                        case '}':
                            valid = lastBracket == '{';
                            break;
                        case ')':
                            valid = lastBracket == '(';
                            break;
                    }
                    if (!valid) return false;
                }
            }
            return brackets.Count == 0; 
        }
    }
}
