// Customer Access: If customer is premium OR order amount > ₹50,000 → Apply discount; else no discount.

using System;
class CustomerAccess
{
    public static void Main()
    {
        bool ispremium = true;
        int orderamount = 65890;

        if(ispremium || orderamount> 50000)
        {
            Console.WriteLine("Apply discount");
        }
        else
        {
            Console.WriteLine("no discount");
        }
    }
}