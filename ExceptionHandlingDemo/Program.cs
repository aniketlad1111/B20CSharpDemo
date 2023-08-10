class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Calculator");

        try
        {
            Divide();
        }
        catch (StudentException ex)
        {
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine("Error handled in outer try catch block");
        }

        //try
        //{

        //}
        //finally
        //{

        //}


        Console.WriteLine("Thank you, Visit Again !!!");

        Console.ReadLine();
    }

    static void Divide()
    {
        try
        {
            Console.WriteLine("Please enter a numerator");

            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Please enter a denominator");
                int d;
                if (int.TryParse(Console.ReadLine(), out d))
                {
                    int division = n / d;
                    Console.WriteLine($"Division : {n} / {d} = {division}");

                    //if (d != 0)
                    //{
                    //    int division = n / d;
                    //    Console.WriteLine($"Division : {n} / {d} = {division}");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Denominator cannot be zero");
                    //}
                }
                else
                {
                    Console.WriteLine("Please enter a valid denominator");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numerator");
            }

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a denominator");
            //int d = int.Parse(Console.ReadLine());

            //int division = n / d;

            //Console.WriteLine($"Division : {n} / {d} = {division}");
        }
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Denominator cannot be zero.");
        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine("Please enter a valid number");
        //}
        //catch (OverflowException ex)
        //{
        //    Console.WriteLine("Please enter a valid number range");
        //}
        catch (Exception ex)
        {
            // throw;
            // throw new DirectoryNotFoundException();
            throw new StudentException("My Custom Exception Class");

            //Console.WriteLine(ex.GetType().Name);
            //Console.WriteLine(ex.Message);
            //Console.WriteLine("Server error");

            // File.AppendAllText(@"Data1\Data2\logs-new.txt", ex.Message);
            Console.WriteLine("Please check error log in log file");
        }
        finally
        {
            Console.WriteLine("Division Operation Completed");
        }
    }
}

class StudentException : Exception
{
    public StudentException(string message) : base(message)
    {

    }
}