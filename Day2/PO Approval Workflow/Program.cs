// PO Approval Workflow: If PO amount > ₹5,00,000, require Director approval; else Manager approval; else auto-approve.
using System;
class POApproval
{
    public static void Main()
    {
        int POAmount = 6500000;
        if(POAmount > 500000)
        {
            Console.WriteLine("require Director approval");
        }
        else if(POAmount > 100000)
        {
          Console.WriteLine("require Manager approval");   
        }
        else
        {
            Console.WriteLine("auto-approve");  
        }
    }
}
