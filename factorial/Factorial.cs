using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

class FactorialSolution
{
  static void Main(String[] args)
  {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    int n = Convert.ToInt32(Console.ReadLine());
    BigInteger result = Factorial(n);

    Console.WriteLine(result);
  }

  public static BigInteger Factorial(int n)
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
      return n * (Factorial(n - 1));
    }
  }
}