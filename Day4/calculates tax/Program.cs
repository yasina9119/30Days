// Build a function that calculates tax on an amount and returns the final invoice total.
using System;
class CalculateTotal
{
    public static void Main()
    {
        static double CalculateTotal(double amount, double taxRate)
        {
            double tax = amount * taxRate / 100;
            return amount + tax;
        }
        Console.WriteLine(CalculateTotal(1000, 18));
    }
}