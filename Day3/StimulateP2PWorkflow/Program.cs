using System;

class P2PWorkflow
{
    public static void Main()
    {
        bool isRequisition = true;
        bool isFormalPO = true;
        bool isProductReceipt = true;
        bool isVendorInvoice = true;

        if (isRequisition)
        {
            Console.WriteLine("Requisition created");

            if (isFormalPO)
            {
                Console.WriteLine("Formal PO created");

                if (isProductReceipt)
                {
                    Console.WriteLine("Product Receipt completed");

                    if (isVendorInvoice)
                    {
                        Console.WriteLine("Vendor Invoice generated");

                        Console.WriteLine("Payment triggered");
                    }
                }
            }
        }
    }
}
