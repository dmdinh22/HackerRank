using System;

namespace HackerRank.ThirtyDOC
{
    public class Generics
    {
        public static void PrintArray<T>(T[] input)
        {
            foreach (T value in input)
            {
                Console.WriteLine(value);
            }
        }
    }
}