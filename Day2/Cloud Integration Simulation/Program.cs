// Cloud Integration Simulation: If API connection is live → Push PO data; else retry.

using System;
class CloudIntegration
{
    public static void Main()
    {
        bool isLive = false;

        if(isLive == false)
        {
            Console.WriteLine("retry");
        }
        else
        {
         Console.WriteLine("Push PO data");   
        }
    }
}
