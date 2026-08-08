// Vendor Comparison: Compare two suppliers’ quotes(price) and select the cheaper one.

using System;
class VendorComparison
{
   public static void Main()
    {
        int supplier1 = 25000;
        int supplier2 = 30000;

        if(supplier1 < supplier2)
        {
            Console.WriteLine("Select supplier one quote is cheaper");
        }
        else
        {
            Console.WriteLine("Select supplier2 qoute is cheaper");
        }
    }
}
