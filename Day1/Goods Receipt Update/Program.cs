// Goods Receipt Update: After payment, mark items as “Received” and update stock levels.
using System;
class GoodsReceiptUpdate
{
    public static void Main()
    {
        bool ispayment = true;

        string item1 = "Lenevo";
        int stock1 = 10;

        string item2 = "Dell";
        int stock2 = 15;

        string item3 = "HP";
        int stock3 = 8;

        string item4 = "Asus";
        int stock4 = 12;

        string item5 = "Vivo";
        int stock5 = 20;

        if (ispayment == true)
        {
            Console.WriteLine($"mark items {item1},{item2},{item3},{item4},{item5} as “Received” and update stock levels are :");
            stock1 = stock1 + 4;
            Console.WriteLine($"Updated Lenovo stock: {stock1}");

            stock2 = stock2 + 4;
            Console.WriteLine($"Updated Dell stock: {stock2}");

            stock3 = stock3 + 4;
            Console.WriteLine($"Updated HP stock: {stock3}");

            stock4 = stock4 + 4;
            Console.WriteLine($"Updated Asus stock: {stock4}");

            stock5 = stock5 + 4;
            Console.WriteLine($"Updated Vivo stock: {stock5}");

        }

    }
}