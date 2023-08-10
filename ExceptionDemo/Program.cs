class Program
{
    static void Main()
    {
        string choice = string.Empty;
        do
        {
            try
            {
                Console.WriteLine("Please enter numerator");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter denominator");
                int j = Convert.ToInt32(Console.ReadLine());

                int div = i / j;

                Console.WriteLine($"Division {i} / {j} = {div}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Do you want to continue?");
            choice = Console.ReadLine().ToUpper();
        } while (choice == "Y" || choice == "YES");

        Console.WriteLine("Thank you Visit Again !!!");

        Console.ReadLine();
    }
}

