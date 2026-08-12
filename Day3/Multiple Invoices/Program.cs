// Store multiple invoice amounts in an array and process only those with matching receipts.

using System;
class MultipleInvoices
{
    public static void Main()
    {
        double[] invoiceAmounts = new double[5];
        invoiceAmounts[0]=8760;
        invoiceAmounts[1]=4790;
        invoiceAmounts[2]=5000;
        invoiceAmounts[3]=1000;
        invoiceAmounts[4]=2400;

        double [] receipts = {8760,3456,5000,1000,3098};

        for(int i = 0; i< invoiceAmounts.Length; i++)
        {
            if(invoiceAmounts[i] == receipts[i])
            {
                Console.WriteLine($"Invoice {invoiceAmounts[i]} has a matching receipt");
            }
        }

    }
}
