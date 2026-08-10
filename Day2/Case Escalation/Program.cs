// Case Escalation (CE): If case unresolved > 48 hours → cc else keep in queue.

using System;
class CaseEscalation
{
    public static void Main()
    {
        bool isUnresolved = true;
        double hrs = 55;

        if (isUnresolved && hrs > 48)
        {
            Console.WriteLine("Escalate to Manager");
        }
        else
        {
            Console.WriteLine("Keep in queue");
        }


    }
}
