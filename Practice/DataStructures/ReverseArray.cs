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

namespace HackerRank.Practice.DataStructures
{
    public class ReverseArray
    {
        static int[] reverseArray(int[] a)
        {
            Array.Reverse(a);
            return a;
        }

        // using for loop
        static int[] reverseArrayForLoop(int[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                int currentIndex = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = currentIndex;
            }

            return a;
        }

    }
}