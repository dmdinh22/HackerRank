using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank .30 DOC
{
    public class DataTypes
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int x;
            double y;
            string inputString;
            // Read and save an integer, double, and String to your variables.
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            inputString = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + x);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:F1}", d + y); // convert to decimal
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + inputString);
        }
    }