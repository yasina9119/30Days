// Vendor Selection: If vendor rating ≥ 4 AND delivery time ≤ 7 days → Select vendor; else reject.
using System;
class VendorSelection
{
    public static void Main()
    {
        int rating = 5;
        int delivery = 4;

        if(rating >= 4 && delivery <= 7)
        {
            Console.WriteLine("Select vendor");
        }
        else
        {
          Console.WriteLine("Reject vendor");   
        }
    }
}