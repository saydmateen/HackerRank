using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ContactTries
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-contacts/problem
        /// </summary>
        public static void Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<char, List<string>> list = new Dictionary<char, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                string word = line[1];
                char key = word[0];
                if (line[0].Equals("find"))
                {
                    int count = FindString(list, word);
                    Console.WriteLine(count);
                }
                else
                {
                    if (list.ContainsKey(key))
                    {
                        var temp = new List<string>();
                        list.TryGetValue(key, out temp);
                        temp.Add(word);
                        list[key] = temp; 
                    }
                    else
                    {
                        var temp = new List<string>();
                        temp.Add(word);
                        list.Add(key, temp);
                    }
                }
            }
        }

        public static int FindString(Dictionary<char,List<string>> list, string find)
        {
            char key = find[0];
            int count = 0;
            int findLength = find.Length;
            var temp = new List<string>();
            list.TryGetValue(key, out temp);
            if (temp == null || temp.Count == 0) return count;
            foreach (string s in temp)
            {
                bool found = true;
                if (findLength > s.Length) continue;
                for (int i = 1; i < findLength; i++)
                {
                    if (s[i] != find[i])
                    {
                        found = false;
                        break;
                    }
                }
                if (found) count++;
            }
            return count;
        }
    }
}
