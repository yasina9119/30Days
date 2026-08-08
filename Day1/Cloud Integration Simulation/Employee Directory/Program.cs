
// Employee Directory: Store 5 employee names in a List and print all employee names.using System;
using System.Collections.Generic;

class EmployeeDirectory
{
    public static void Main()
    {
        List<string> EmployeeNames = new List<string>();

        EmployeeNames.Add("Bunny");
        EmployeeNames.Add("cutie");
        EmployeeNames.Add("chintu");
        EmployeeNames.Add("kanna");
        EmployeeNames.Add("sweety");

        Console.WriteLine("EmployeeNames:");

        foreach(string EmployeeName in EmployeeNames)
        {
            Console.WriteLine(EmployeeName);
        }

    }
}