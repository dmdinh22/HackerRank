using System;
using System.Collections.Generic;
using System.IO;

class Nested 
{
    static void NestedMain(String[] args) 
    {
        Console.WriteLine("Enter actual day");
        int actualDay =   Convert.ToInt32(Console.ReadLine());            
        Console.WriteLine("Enter actual month");

        int actualMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter actual year");

        int actualYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter expected day");

        int expectedDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter expected month");

        int expectedMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter expected year");

        int expectedYear = Convert.ToInt32(Console.ReadLine());

        int monthsLate = actualMonth - expectedMonth;
        int daysLate = actualDay - expectedDay;
        int yearDiference = actualYear - expectedYear;

        Console.WriteLine((actualYear - expectedYear > 0) ? 10000
        : (actualMonth - expectedMonth > 0 && yearDiference == 0) ? monthsLate * 500
                : (actualDay - expectedDay > 0 && yearDiference == 0) ? daysLate * 15
                        : 0);
                        
        Console.ReadLine();
    }
}