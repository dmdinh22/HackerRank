using System;

namespace HackerRank.ThirtyDOC
{
    public class Operators
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = meal_cost * tip_percent / 100;
            double tax = meal_cost * tax_percent / 100;

            double total = meal_cost + tip + tax;

            Console.WriteLine("The total meal cost is " + Math.Round(total) + " dollars.");
        }

        // static void Main(string[] args)
        // {
        //     double meal_cost = Convert.ToDouble(Console.ReadLine());

        //     int tip_percent = Convert.ToInt32(Console.ReadLine());

        //     int tax_percent = Convert.ToInt32(Console.ReadLine());

        //     solve(meal_cost, tip_percent, tax_percent);
        // }
    }
}