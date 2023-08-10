class Program
{
    static void Main()
    {
        Customer c1 = new Customer();
        Console.WriteLine(c1.Name);

        //c1.Orders = c1.GetOrders();

        //Console.WriteLine("*** All Orders ***");
        //foreach (Order item in c1.Orders.Value)
        //{
        //    Console.WriteLine($"{item.OrderId} : {item.OrderDescription}");
        //}

        Console.ReadLine();
    }
}

class Order
{
    public int OrderId { get; set; }
    public string OrderDescription { get; set; }
}

class Customer
{
    public string Name { get; set; }
    public Lazy<List<Order>> Orders { get; set; }

    public Customer()
    {
        Name = "Vishal";
        // Orders = GetOrders();

        //Func<List<Order>> del = GetOrders;
        //Orders = new Lazy<List<Order>>(del);

        Orders = new Lazy<List<Order>>(() => GetOrders());
    }

    public List<Order> GetOrders()
    {
        return new List<Order>()
        {
        new Order(){OrderId = 1, OrderDescription = "Order 1"},
        new Order(){OrderId = 2, OrderDescription = "Order 2"},
        new Order(){OrderId = 3, OrderDescription = "Order 3"}
        };
    }
}