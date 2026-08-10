// Shipment Logic: If goods received AND payment completed → Mark shipment as “Released.”

using System;
class ShipmentLogic
{
    public static void Main()
    {
        bool isgoodsReceived = true;
        bool ispaymentCompleted = true;
        string shipment = "Released";

        if(isgoodsReceived && ispaymentCompleted )
        {
            Console.WriteLine($"Mark Shipment as {shipment}");
        }
    }
}
