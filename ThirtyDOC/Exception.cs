using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.ThirtyDOC
{
    public class Exception
    {
        static void ExceptionMain(String[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}