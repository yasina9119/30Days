// Create a function that accepts a customer name and product, and returns an order confirmation string. 
using System;
class OrderConfirmation
{
    public static void Main()
    {
        static string accepts(string customername, string product)
        {
            return $"Order confirmed for {customername}: {product}";
        }
        Console.WriteLine(accepts("yasina", "co-ord set"));
    }
}