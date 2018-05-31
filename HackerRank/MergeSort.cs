using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class MergeSort
    {
        public static void Solution()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine( 
                    CountInversion(
                        Array.ConvertAll(
                            Console.ReadLine().Split(' '), 
                            Convert.ToInt32
                        ),
                        size
                    )
                );
            }
        }

        public static int CountInversion(int[] arr, int size)
        {
            int count = 0;

            return count; 
        }
    }
}
