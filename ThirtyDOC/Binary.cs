using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace HackerRank.ThirtyDOC
{
    public class Binary
    {
        static void BinaryMain(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int numRow = 0;
            int numInOrder = 0;
            string binary = Convert.ToString(n, 2);

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    numInOrder++;
                    numRow = Math.Max(numRow, numInOrder);
                }
                else
                {
                    numInOrder = 0;
                }
            }
            Console.WriteLine(numRow);
        }
    }
}