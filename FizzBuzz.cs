using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var line1 = System.Console.ReadLine().Trim();
        var N = Int32.Parse(line1);
        
        for (var i = 1; i <= N; i++) {
            if (i % 15 == 0) {
                System.Console.WriteLine("FizzBuzz");
            } else if (i % 3 == 0) {
                System.Console.WriteLine("Fizz");
            } else if (i % 5 == 0) {
                System.Console.WriteLine("Buzz");
            } else {
                System.Console.WriteLine(i);
            }
        }
    }
}