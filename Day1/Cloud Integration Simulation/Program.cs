// Cloud Integration Simulation: Store invoice details in a list (mock Dataverse table) and print all invoices.
using System;
using System.Collections.Generic;

class CloudIntegrationSimulation
{
    public static void Main()
    {
        List<string> invoices = new List<string>();

        invoices.Add("INV001 - Lenovo - ₹65000");
        invoices.Add("INV002 - Dell - ₹70000");
        invoices.Add("INV003 - HP - ₹55000");

        Console.WriteLine("All Invoices:");

        foreach (string invoice in invoices)
        {
            Console.WriteLine(invoice);
        }
    }
}
