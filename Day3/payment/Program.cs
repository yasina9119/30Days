// Modify the program to block payment if invoice amount > ₹1,00,000 without manager approval.
using System;
class Payment
{
    public static void Main()
    {
        double InvoiceAmount = 250000;
        bool isapprovalneeded = false;

        if(InvoiceAmount > 100000 && !isapprovalneeded)
        {
            Console.WriteLine("Block the payment");
        }
        else
        {
         Console.WriteLine("UnBlock the payment");   
        }
    }
}