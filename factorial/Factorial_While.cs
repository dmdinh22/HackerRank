using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class FactorialWhileSolution {
    // static void Main(String[] args) {
    //     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    //     int n = Convert.ToInt32(Console.ReadLine());
    //     BigInteger result = Factorial(n);
        
    //     Console.WriteLine(result);
    // }
    
    // Account for large numbers that 64 bit cannot handle with BigInteger struct
    public static BigInteger Factorial(int n)
    {
        BigInteger result = n;
        
        if ( n == 0 || n == 1) {
            return 1;
        }
        
        while (n > 1) {
            n--;
            result = result * n;
        }
        
        return result;
    }
}

