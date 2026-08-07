// Approval Workflow: If grand total > ₹1,00,000, print “Manager Approval Required,” else “Auto-Approved.

using System;
class Approvalworkflow
{
    public static void Main()
    {
        // purchase order details
        string item = "steel";
        int quantity = 10;
        double unitPrice = 65000;

        // total
       double total = quantity * unitPrice;

        if(total > 100000)
        {
            Console.WriteLine("manage approval is required");
        }
        else
        {
            Console.WriteLine("Auto approve");
        }

    }
}