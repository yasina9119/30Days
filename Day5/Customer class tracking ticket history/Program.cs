// Customer class tracking ticket history
// Create a Customer class with properties Name, Email, and TicketHistory (as a List<string>).
// Add a method AddTicket(string ticket) that stores a ticket in the list.
// Write a method ShowTickets() that prints all tickets for the customer.
// Extend the Customer class to also track Sales Orders in a List<SalesOrder>.
// Add validation in the Email property so it must contain "@".

using System;
using System.Collections.Generic;

class SalesOrder
{
}

class Customer
{
    public string Name { get; set; } = "";

    private string email = "";

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (value.Contains("@"))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }

    public List<string> TicketHistory { get; set; } = new List<string>();

    public List<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public void AddTicket(string ticket)
    {
        TicketHistory.Add(ticket);
    }

    public void ShowTickets()
    {
        foreach (string ticket in TicketHistory)
        {
            Console.WriteLine(ticket);
        }
    }
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer();

            customer.Name = "Yasina";
            customer.Email = "yasina@gmail.com";

            customer.AddTicket("Login issue");
            customer.AddTicket("Payment issue");

            customer.ShowTickets();
        }
    }
}