// Partial Payment: Simulate a case where only 50% of the grand total is paid upfront.

using System;
class PartialPayment
{
    public static void Main()
    {
        string item = "metal";
        int Qty = 5;
        double UnitPrice = 43250;

       double total = Qty * UnitPrice;
       double tax = total * 0.18;
       double grandTotal = total + tax;

       double upfrontPayment = grandTotal * 0.50;

       Console.WriteLine($"Upfront payment: {upfrontPayment}");
    }
}