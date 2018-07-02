using System;

namespace HackerRank.ThirtyDOC
{
    public class Arrays
    {
        static void ArraysMain(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for (var i = n - 1; i > -1; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}