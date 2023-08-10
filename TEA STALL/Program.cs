class Program
{
    static void Main()
    {
        int TotalBill = 0;
        string choice = "";
        int TotalSamosa = 0, TotalWadapav = 0, TotalTea = 0, TotalCoffee = 0;
        Console.WriteLine("----------Today's Menu-----------");

        do
        {
            Console.WriteLine("Wada pav\tSamosa\tTea\tCoffee");
            Console.WriteLine("What would you like to take ?");
            string order = Console.ReadLine();

            switch (order.ToUpper())
            { 
                case "Wada pav":
                Console.WriteLine("How many Wada pav");
                int tw = int.Parse(Console.ReadLine());
                //totalbill += 20;
                break;

            case "Samosa":
                Console.WriteLine("How many Samosa ?");
                int ts = int.Parse(Console.ReadLine());
                //totalbill += 12;
                break;

            case "Tea":
                Console.WriteLine("How many Tea ?");
                int tt = int.Parse(Console.ReadLine());
                //totalbill += 10;
                break;

            case "Coffee":
                Console.WriteLine("How many Coffee ?");
                int tc = int.Parse(Console.ReadLine());
                //totalbill += 15;
                break;

            default:
                Console.WriteLine($"{order} not available");
                break;
            }

            Console.WriteLine("Do you want to continue ?");
            choice = Console.ReadLine().ToUpper();

        } while (choice == "Y" || choice == "YES");

        if (TotalWadapav > 0 || TotalSamosa > 0 ||
            TotalTea > 0 || TotalCoffee > 0)
        {
            Console.WriteLine("********** BILL RECEIPT **********");
        }

        if (TotalWadapav > 0)
        {
            Console.WriteLine($"Wadapav {TotalWadapav} * 20 : {TotalWadapav * 20}");
            TotalBill += TotalWadapav * 20;
        }
        if (TotalSamosa > 0)
        {
            Console.WriteLine($"Samosa {TotalSamosa} * 12 : {TotalSamosa * 12}");
            TotalBill += TotalSamosa * 12;
        }
        if (TotalTea > 0)
        {
            Console.WriteLine($"Tea {TotalTea} * 10 : {TotalTea * 10}");
            TotalBill += TotalTea * 10;
        }
        if (TotalCoffee > 0)
        {
            Console.WriteLine($"Coffee {TotalCoffee} * 15 : {TotalCoffee * 15}");
            TotalBill += TotalCoffee * 15;
        }
        if (TotalBill > 0)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Total Bill Amount : {TotalBill}");
        }
        else
        {
            Console.WriteLine("NO BILL");
        }

        Console.WriteLine(); // new line
        Console.WriteLine("Thank You. Visit Again");


        Console.ReadLine();
    }
}
