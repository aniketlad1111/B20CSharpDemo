class Program
{
    static void Main()
    {
        VIPCustomer vip = new VIPCustomer();

        ((ISilverCustomer)vip).PrintTicket();
        ((IGoldCustomer)vip).PrintTicket();

        vip.PrintS();
        vip.PrintG();


        Console.ReadLine();
    }
}


abstract class Customer
{
    public abstract void PrintTicket();
}


interface ISilverCustomer
{
    void PrintTicket();
    void PrintS();
}
class SilverCustomer : Customer , ISilverCustomer
{
    public void PrintS()
    {
        Console.WriteLine("Silver class PrintS()");
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket");
    }
}


interface IGoldCustomer
{
    void PrintTicket();
    void PrintG();
}

class GoldCustomer : Customer, IGoldCustomer
{
    public void PrintG()
    {
        Console.WriteLine("Silver class PrintG()");
    }

    public override void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket");
    }
}

class VIPCustomer : ISilverCustomer, IGoldCustomer
{
    SilverCustomer sc = new SilverCustomer();
    GoldCustomer gc = new GoldCustomer();

    public void PrintS()
    {
        sc.PrintS();
    }

    public void PrintG()
    {
        gc.PrintG();
    }

    void ISilverCustomer.PrintTicket()
    {
        sc.PrintTicket();
    }

    void IGoldCustomer.PrintTicket()
    {
        gc.PrintTicket();
    }
}