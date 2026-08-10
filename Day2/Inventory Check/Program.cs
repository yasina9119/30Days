// Inventory Check: If stock < 50 OR demand > 100 → Trigger replenishment order.
using System;
class InventoryCheck
{
    public static void Main()
    {
        int stock = 43;
        int demand = 120;

        if(stock < 50 ||  demand > 100)
        {
            Console.WriteLine("Trigger replenishment order");
        }
    
    }
}