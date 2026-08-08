// Currency Conversion: Convert the grand total from INR to GBP using a fixed conversion rate.
using System;
class CurrencyConversion
{
    public static void Main()
    {
        string item = "iron";
        int Qty = 19;
        double UnitPrice = 987620;
        double discount = 10000;
        double inrToGbp = 0.009;

        double subtotal = Qty * UnitPrice;
        double tax = subtotal * 0.12;
        double total = subtotal - discount;
        double grandTotal = total + tax;
        double grandTotalGBP = grandTotal * inrToGbp;

        Console.WriteLine($"grand total for the item {item} from INR to GBP using a fixed conversion rate{(inrToGbp)} is : {grandTotalGBP}");


    }
}