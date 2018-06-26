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

namespace HackerRank.Practice.Algos
{
    public class CompareTriplets
    {
        // static int[] solve(int[] a, int[] b)
        // {
        //     int alicePts = ((a[0] > b[0]) ? 1 : 0) +
        //         ((a[1] > b[1]) ? 1 : 0) +
        //         ((a[2] > b[2]) ? 1 : 0);
        //     int bobPts = ((a[0] < b[0]) ? 1 : 0) +
        //         ((a[1] < b[1]) ? 1 : 0) +
        //         ((a[2] < b[2]) ? 1 : 0);

        //     return new int[] { alicePts, bobPts };
        // }

        // using TUPLES!
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] result = new int[2];

            var tuples = new List<Tuple<int, int>>()
                {
                    Tuple.Create(a0, b0),
                    Tuple.Create(a1, b1),
                    Tuple.Create(a2, b2)
                };

            foreach (var tuple in tuples)
            {
                if (tuple.Item1 > tuple.Item2)
                    result[0] += 1;
                else if (tuple.Item2 > tuple.Item1)
                    result[1] += 1;
            }

            return result;
        }
    }
}