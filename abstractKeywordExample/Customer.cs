public abstract class Customer
{
    public Customer() 
    {
        Console.WriteLine("*** Welcome to Abhiruchi ***");
    }

    public static void ShowTimings()
    {
        Console.WriteLine($"All Shows for Today");
    }

    public abstract int GetTicketAmount();
    public abstract int GetTicketAmount(bool isVIP);
    public abstract void PrintTicket();
}

public class SilverCustomer : Customer
{
    
    public override int GetTicketAmount()
    {
        return 150;
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket Printed.");
    }
    public override int GetTicketAmount(bool isVIP)
    {
        if (isVIP)
            return 150 - (150 / 10);
        else
            return 150;
    }

}

public class GoldCustomer : Customer
{
    public override int GetTicketAmount()
    {
        return 250;
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket Printed.");
    }
    public override int GetTicketAmount(bool isVIP)
    {
        if (isVIP)
            return 250 - (250 / 10);
        else
            return 250;
    }
}
 