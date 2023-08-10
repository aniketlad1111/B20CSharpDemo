class Program
{
    static void Main()
    {
        // ICustomer c1 = new ICustomer();

        //ICustomer c1 = new SilverCustomer();
        //c1.Print();
        //c1.SaveCustomerDetails();

        //ICustomer c2 = new GoldCustomer();
        //c2.Print();
        //c2.SaveCustomerDetails();

        //IFood f1 = new SilverCustomer();
        //f1.Orders();

        //IFood f2 = new GoldCustomer();
        //f2.Orders();

        //SilverCustomer sc1 = new SilverCustomer();
        //sc1.SaveCustomerDetails();

        ICustomer c1 = new SilverCustomer();
        c1.SaveCustomerDetails();

        IFood f1 = new SilverCustomer();
        f1.SaveCustomerDetails();

        SilverCustomer sc1 = new SilverCustomer();
        // sc1.SaveCustomerDetails();

        ((ICustomer)sc1).SaveCustomerDetails();
        ((IFood)sc1).SaveCustomerDetails();

        Console.ReadLine();
    }
}

interface ICustomer
{
    //     string FirstName;
    //public ICustomer()
    //{

    //}

    public string FirstName { get; set; }

    void Print();
    void SaveCustomerDetails();

    // void PrintFirstName();

    public void PrintFirstName()
    {
        Console.WriteLine("PrintFirstName()");
    }
}

interface IFood
{
    void Orders();
    void SaveCustomerDetails();
}

class SilverCustomer : ICustomer, IFood
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }


    public void Orders()
    {
        Console.WriteLine("Silver Customer Orders");
    }

    public void Print()
    {
        Console.WriteLine("Silver Customer");
    }

    void ICustomer.SaveCustomerDetails()
    {
        Console.WriteLine("ICustomer SaveCustomerDetails()");
    }

    void IFood.SaveCustomerDetails()
    {
        Console.WriteLine("IFood SaveCustomerDetails()");
    }

    //public void SaveCustomerDetails()
    //{
    //    Console.WriteLine("Silver Customer SaveCustomerDetails()");
    //}
}

class GoldCustomer : ICustomer, IFood
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public void Print()
    {
        Console.WriteLine("Gold Customer");
    }

    public void Orders()
    {
        Console.WriteLine("Gold Customer Orders");
    }

    public void SaveCustomerDetails()
    {
        Console.WriteLine("Gold Customer SaveCustomerDetails()");
    }
}