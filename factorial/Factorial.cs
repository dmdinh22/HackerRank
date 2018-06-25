using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Factorial(n));
    }
    
    public static int Factorial(int n)
    {
      if (n < 0) 
      {
        return -1;
      }

      else if (n == 0) 
      {
        return 1;
      }

      else
      {
        return (n * Factorial(n-1));
      }
    }
}

