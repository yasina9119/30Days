// Order Management Simulation: Store customer order details in a List and print all orders.
using System;
using System.Collections.Generic;

class CustomerOrderSimulation
{
    public static void Main()
    {
        List<string> orders = new List<string>();

        orders.Add("ORD001 - Yasina - Laptop");
        orders.Add("ORD002 - Happy - Keyboard");
        orders.Add("ORD003 - Rizwana - Mouse");

        Console.WriteLine("All Orders:");

        foreach (string order in orders)
        {
            Console.WriteLine(order);
        }
    }
}