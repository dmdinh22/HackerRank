using System;

namespace HackerRank.ThirtyDOC
{
    public class Loops
    {
        class Solution
        {
            static void Entry(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    int result = n * i;
                    Console.WriteLine(n + " x " + i + " = " + result);
                }
            }
        }

    }
}