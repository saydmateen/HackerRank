using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class HashTable
    {
        public static void Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                int money = Convert.ToInt32(Console.ReadLine());
                int count = Convert.ToInt32(Console.ReadLine());
                List<int> cost = new List<int>();
                while (cost.Count != count)
                {
                    cost.Add(Convert.ToInt32(GetWord()));
                }
                Console.ReadLine();
                Solve(cost.ToArray(), money);
            }
        }

        static string GetWord()
        {
            StringBuilder num = new StringBuilder();
            char c = (char)Console.Read();
            while (c >= 0 && c != ' ' && c != '\r' && c != '\n')
            {
                num.Append(c);
                c = (char)Console.Read();
            }
            return num.ToString();
        } 

        static void Solve(int[] cost, int money)
        {
            Tuple<int, int> flavors = null;
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int k = 0; k < cost.Length; k++)
            {
                if (cost[k] < money)
                {
                    pairs.Add(k + 1, cost[k]);
                }
            }

            foreach (var item in pairs)
            {
                int find = money - item.Value;
                int found = pairs.FirstOrDefault(x => x.Value == find && x.Key != item.Key).Key;
                if (found != 0)
                {
                    flavors = found > item.Key ? new Tuple<int, int>(item.Key, found) : new Tuple<int, int>(found, item.Key);
                    break;
                }
            }

            Console.WriteLine("{0} {1}", flavors.Item1, flavors.Item2);
        }
    }
}