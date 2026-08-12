// Create a program that prints “Formal PO created” only when requisition + approval both exist.
using System;
class FormalPOCreated
{
    public static void Main()
    {
        bool isrequisition = true;
        bool isapproval = true;

        if(isrequisition && isapproval)
        {
            Console.WriteLine("Formal PO Created");
        }
    }
}
