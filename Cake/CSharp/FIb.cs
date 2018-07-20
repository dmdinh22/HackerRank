using System;
using System.Collections.Generic;

public class FibSolution
{

    // Recursive solution 
    public static int FibRecursive(int n)
    {
        // Compute the nth Fibonacci number
        // Fib is the sum of the two previous Fib numbers
        // Fib(n) = Fib(n-1) + Fib(n-2)
        
        // base case
        if (n < 2)
        {
            // for 0 and 1, return itself
            return n;
        }

        return FibRecursive(n - 1) + FibRecursive(n - 2);
    }
    // bad timecomplexity - each Fib() call makes TWO more calls.
    // ie. FibRecursive(5) creates a binary tree - O(2^n) runtime
    // - aka "exponential time cost" - TERRIBLE
    // to avoid the repeat work - use MEMOIZATION

    private Dictionary<int, int> _memo - new Dictionary<int, int>();

    public int FibMemo(int n)
    {
        // edge case - NEGATIVE index
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n),
                "Index was negative. No such thing as a negative index in a series.");
        }

        // base case: 0 or 1
        if ( n < 2)
        {
            return n;
        }

        // see if we've already calculated this result
        int result;
        if (!_memo.TryGetValue(n, out result))
        {
            // not yet, so comput it
            result = FibMemo(n - 1) + FibMemo(n - 2);

            //Memoize this result by adding it to the dict
            _memo.Add(n, result);

            return result;
        }
    }

    // -with memoization, the call stack for Fib(5) is 
    // Fib(5), Fib(4), Fib(3), Fib(2), Fib(1)
    // which would e n time in total
    // -memo takes up n space, and building up a call stack that takes 
    // n space also.
    // to avoid the buildup of call stack, use BOTTOM UP

    // Bottom Up Approach
    public static int Fib(int n)
    {
            // Edge cases:
        if (n < 0)
        {
            throw new ArgumentException("Index was negative. No such thing as a negative index in a series.");
        }

        if (n < 2)
        {
            return n;
        }

        // we'll be buliding the fib series from the bottom up.
        // so we'll need to track the prev 2 numbers at each step.
        int prevPrev = 0;   // 0th fib
        int prev = 1;       // 1st fib
        int current = 0;    // declare and initialize current fib

        for (var i = 0; i < n; i ++)
        {
            // iteration 1: current = 2nd fib
            // iteration 2: current = 3rd fib
            // iteration 3: current = 4th fib
            // to get nth fib... do n - 1 iterations
            current = prev + prevPrev;
            prevPrev = prev;
            prev = current;
        }

        return current;
    }

    // BOTTOM UP has O(n) time and O(1) space
    // Fibonnaci series is a good illustration of tradeoff we have
    // bt clean code and efficiency

    // Recursive solution might build up a call stack, 
    //so iterative might be more efficient

    // Tests
    [Fact]
    public void ZerothFibonacciTest()
    {
        var actual = Fib(0);
        var expected = 0;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FirstFibonacciTest()
    {
        var actual = Fib(1);
        var expected = 1;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SecondFibonacciTest()
    {
        var actual = Fib(2);
        var expected = 1;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThirdFibonacciTest()
    {
        var actual = Fib(3);
        var expected = 2;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FifthFibonacciTest()
    {
        var actual = Fib(5);
        var expected = 5;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TenthFibonacciTest()
    {
        var actual = Fib(10);
        var expected = 55;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NegativeFibonacciTest()
    {
        Assert.Throws<ArgumentException>(() => Fib(-1));
    }

    public static void Main(string[] args)
    {
        TestRunner.RunTests(typeof(Solution));
    }
}