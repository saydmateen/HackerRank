﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class HashNoteReplica
    {
        /// <summary>
        /// Hacker Rank Problem: https://www.hackerrank.com/challenges/ctci-ransom-note/problem
        /// </summary>
        const string y = "Yes";
        const string n = "No";
        public static void Solution()
        {
            string[] token = Console.ReadLine().Split(' ');
            if (Convert.ToInt32(token[0]) < Convert.ToInt32(token[1]))
            {
                Console.WriteLine(n);
                return;
            }

            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');
            Dictionary<string, int> magazineDict = new Dictionary<string, int>();
            Dictionary<string, int> ransomDict = new Dictionary<string, int>();

            foreach(var word in magazine)
            {
                if (magazineDict.ContainsKey(word))
                    magazineDict[word] += 1;
                else
                    magazineDict[word] = 1;
            }
           
            foreach(var word in ransom)
            {
                if (ransomDict.ContainsKey(word))
                    ransomDict[word] += 1;
                else
                    ransomDict[word] = 1;
            }

            foreach(var pair in ransomDict)
            {
                if (magazineDict.ContainsKey(pair.Key) && (magazineDict[pair.Key] >= pair.Value))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(n);
                    return;
                } 
            }

            Console.WriteLine(y);
        }
    }
}
 