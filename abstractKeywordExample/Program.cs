class Program
{
    static void Main()
    {
        Customer c1 = new SilverCustomer();
        // c1.ShowTimings();
        Customer.ShowTimings();
        int result = c1.GetTicketAmount();
        Console.WriteLine($"Silver Ticket Amount : {result}");
        c1.PrintTicket();

        Customer c2 = new GoldCustomer();
        // c2.ShowTimings();
        Customer.ShowTimings();
        result = c2.GetTicketAmount();
        Console.WriteLine($"Gold Ticket Amount : {result}");
        c2.PrintTicket();

        Customer c3 = new GoldCustomer();
        result = c3.GetTicketAmount(true);
        Console.WriteLine($"Gold Ticket Amount : {result}");

        Console.ReadLine();
    }
}