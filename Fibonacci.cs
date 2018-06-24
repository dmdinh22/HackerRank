using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var line1 = System.Console.ReadLine().Trim();
        var n = Int32.Parse(line1);
        Console.WriteLine(Fib(n));
    }
    
    public static int Fib(int n) {
        if (n < 2) {
            return n;
        }
        
        return (Fib(n-1) + Fib(n-2));
    }
}