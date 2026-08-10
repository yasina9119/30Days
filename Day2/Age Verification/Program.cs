// Age Verification: Write a program that checks if a user can create a Purchase Requisition (must be ≥18).
using System;
class Age
{
    public static void Main()
    {
        int Age = 24;

        if(Age >= 18)
        {
            Console.WriteLine("user can create a Purchase Requisition");
        }
        else
        {
         Console.WriteLine("user can't create a Purchase Requisition");   
        }
    }
}