// Customer Order Flow: Simulate Order → Shipment → Delivery confirmation with calculations.
using System;
using System.Collections.Generic;

class CustomerOrderFlow
{
    public static void Main()
    {
        List<string> items = new List<string> { "goldpen", "silverpen", "pens", "pencils" };
        List<double> prices = new List<double> { 500, 300, 200, 30 };
        List<int> quantities = new List<int> { 50, 250, 150, 1000 };

        for (int i = 0; i < items.Count; i++)
        {
            // 1. Order details
            Console.WriteLine($"Order: {items[i]}");
            Console.WriteLine($"Unit Price: ₹{prices[i]}");
            Console.WriteLine($"Quantity: {quantities[i]}");

            // cal
            double total = prices[i] * quantities[i];
            double tax = total * 0.10;
            double grandTotal = total + tax;

            Console.WriteLine($"Quantity: {quantities[i]}");
            Console.WriteLine($"Grand Total: ₹{grandTotal}");

            // 3. Shipment
            string shipmentStatus = "Shipped";
            Console.WriteLine($"Shipment Status: {shipmentStatus}");

            // 4. Delivery confirmation
            string deliveryStatus = "Delivered";
            Console.WriteLine($"Delivery Status: {deliveryStatus}");

            Console.WriteLine("--------------------");
        }






    }
}
