// Build a workflow that prints “Inventory Updated” after each Product Receipt.
using System;

class ProductReceipt
{
    public static void Main()
    {
        string[] productReceipts = { "PR001", "PR002", "PR003" };

        for (int i = 0; i < productReceipts.Length; i++)
        {
            Console.WriteLine($"Product Receipt: {productReceipts[i]}");
            Console.WriteLine("Inventory Updated");
        }
    }
}