// Multi - Item PO: Write a program that handles multiple items (Steel, Cement, Paint) and calculates a combined subtotal, tax, and grand total.

using System;
class Po
{
    static double CalculateTotal(int quantity, double unitPrice)
        {
            return quantity * unitPrice;
        }
    public static void Main()
    {
        // string steel = "Steel";
        // string cement = "Cement";
        // string paint = "Paint";

        int steelQty = 10;
        int cementQty = 20;
        int paintQty = 15;

        double steelPrice = 1200;
        double cementPrice = 850;
        double paintPrice = 1029;

        double taxRate = 0.12;

        double steelTotal = CalculateTotal(steelQty, steelPrice);
        double cementTotal = CalculateTotal(cementQty, cementPrice);
        double paintTotal = CalculateTotal(paintQty, paintPrice);

        double subtotal = steelTotal + cementTotal + paintTotal;

        double taxAmount = subtotal * taxRate;

        double grandTotal = subtotal + taxAmount;

        Console.WriteLine($"steel Total : {steelTotal}");
        Console.WriteLine($"cement Total: {cementTotal}");
        Console.WriteLine($"paint Total : {paintTotal}");
        Console.WriteLine($"subtotal    : {subtotal}");
        Console.WriteLine($"tax         : {taxAmount}");
        Console.WriteLine($"grand Total : {grandTotal}");

    }
}
