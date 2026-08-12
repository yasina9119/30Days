// Simulate a case where Goods Receipt is missing → Payment blocked.
using System;
class GoodsReceipt
{
    public static void Main()
    {
        bool isGoodsReceipt = false;

        if(isGoodsReceipt)
        {
            Console.WriteLine("Payment Successful");
        }
        else
        {
            Console.WriteLine("Payment blocked");
        }
    }
}
