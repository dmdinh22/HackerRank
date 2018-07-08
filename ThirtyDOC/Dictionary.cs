using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.ThirtyDOC
{
    public class Dictionary
    {
        static void DictionaryMain(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Dictionary<string, int> phoneMap = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                string name = values[0];
                int number = Convert.ToInt32(values[1]);

                phoneMap.Add(name, number);
            }

            for (int j = 0; j < n; j++)
            {
                string check = Console.ReadLine();
                if (phoneMap.ContainsKey(check))
                {
                    int output = phoneMap[check];
                    Console.WriteLine("{0}={1}", check, output);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}

// shorter
/*
    int n = Convert.ToInt32(Console.ReadLine());
    var b = Convert.ToString(n,2);
    string[] arr = b.Split('0').ToArray();
    int c = arr.Select(x => x.Length).Max();
    Console.WriteLine(c);
 */