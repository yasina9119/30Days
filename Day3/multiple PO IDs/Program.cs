// Store multiple PO IDs in an array and print which ones are “formalized.”
using System;
class MultiplePOIDs
{
    public static void Main()
    {
        string[] poIds = { "PO101", "PO102", "PO103", "PO104" };

        bool[] formalized = { true, false, true, false };

        for (int i = 0; i < poIds.Length; i++)
        {
            if (formalized[i])
            {
                Console.WriteLine($"{poIds[i]} is formalized");
            }
        }
    }
}