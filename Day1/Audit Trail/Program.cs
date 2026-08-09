using System;
using System.Threading;

class AuditTrail
{
    public static void Main()
    {
        Console.WriteLine($"PO Created: {DateTime.Now}");

        Thread.Sleep(2000);

        Console.WriteLine($"Invoice Generated: {DateTime.Now}");

        Thread.Sleep(2000);

        Console.WriteLine($"Payment Initiated: {DateTime.Now}");
    }
}