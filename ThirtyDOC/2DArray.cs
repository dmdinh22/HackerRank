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

public class TwoDArray
{
    static int HourGlassCheck(int[][] arr)
    {
        int final = 0;
        bool flag = false;
        int add = 0;
        for (int y = 0; y <= 3; y++)
        {
            for (int x = 0; x <= 3; x++)
            {
                add = HourGlassAdd(x, y, arr);
                if (add > final || flag == false)
                {
                    final = add;
                    flag = true;
                }
            }
        }
        return final;
    }

    static void TwoDArrayMain(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        Console.WriteLine(HourGlassCheck(arr));
    }

    static int HourGlassAdd(int x, int y, int[][] arr) => arr[y][x] + arr[y][x + 1] + arr[y][x + 2] + arr[y + 1][x + 1] + arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];
}