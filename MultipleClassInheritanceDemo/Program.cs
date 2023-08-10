using System.Net.Sockets;

class Program
{
    static void Main()
    {
        //CinemaCustomer c1 = new CinemaCustomer();
        //c1.ShowTimings();

        //CinemaCustomer c2 = new SilverCustomer();
        //c2.ShowTimings();

        //Customer c1 = new SilverCustomer();
        //c1.PrintTicket();

        //Customer c2 = new VIPCustomer();
        //c2.PrintTicket();;


        Console.ReadLine();
    }
}

//class CinemaCustomer
//{
//    public void ShowTimings()
//    {
//        Console.WriteLine("All shows for today");
//    }

//    public void SaveCustomerDetails()
//    {
//        Console.WriteLine("Customer Data Saved");
//    }
//}

//class Food
//{
//    public void FoodOrder()
//    {
//        Console.WriteLine("Ordered Food");
//    }

//    public void SaveCustomerDetails()
//    {
//        Console.WriteLine("Customer Data Saved");
//    }
//}

//class SilverCustomer : CinemaCustomer, Food
//// class SilverCustomer : CinemaCustomer
//{

//}

abstract class Customer
{
    public abstract void PrintTicket();
}

class SilverCustomer : Customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket");
    }
}

class GoldCustomer : Customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket");
    }
}

// class VIPCustomer : SilverCustomer, GoldCustomer
class VIPCustomer : SilverCustomer
{

}