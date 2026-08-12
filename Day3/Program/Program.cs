// Write a program that checks if PO + Product Receipt + Vendor Invoice all exist → Trigger payment.
using System;
class P1
{
    public static void Main()
    {
        bool isPOPresent = true;
        bool isPRPresent = true;
        bool isVIPresent = true;

        if(isPOPresent && isPRPresent && isVIPresent)
        {
            Console.WriteLine("Trigger Payment");
        }
        else
        {
             Console.WriteLine("No Trigger");
        }
    }
}