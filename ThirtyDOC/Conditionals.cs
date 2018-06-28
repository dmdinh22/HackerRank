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
    public class Conditionals
    {
        int N = Convert.ToInt32(Console.ReadLine());

        if (N % 2 != 0)
        {
            Console.WriteLine("Weird");
        }
        else if (N % 2 == 0 && N >= 2 && N <= 5)
        {
            Console.WriteLine("Not Weird");
        }

        else if (N % 2 == 0 && N >= 6 && N <= 20)
        {
            Console.WriteLine("Weird");
        }

        else if (N % 2 == 0 && N > 20)
        {
            Console.WriteLine("Not Weird");
        }
    }
}