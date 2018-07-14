using System;

public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
     public int divisorSum(int x)
            {
            int sum = 0;
            for (int i = 1; i < x + 1; i++)
                {
                if (x%i == 0)
                    sum+= i;
            }
        
        return sum;
    }
}