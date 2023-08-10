class Program
{
    static void Main()
    {
        /*Console.WriteLine("Please enter first number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter second number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter third number");
        int c= Convert.ToInt32(Console.ReadLine());*/

        /*if (a > b && a > c)        //if else condition
        {
            Console.WriteLine($"{a} is greater than {b} and {c}");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine($"{b} is greater than {a} and {c}");
        }
        else
        {
            Console.WriteLine($"{c} is greater than {a} and {b}");
        }*/

        /*if (a > b)     //neasted condition
        {
            if (a > c)
            {
                Console.WriteLine($"{a} is greater than {b} and {c}");
            }
            else if (a < c)
            {
                Console.WriteLine($"{c} is greater than {a} and {b}");
            }
            else
            {
                Console.WriteLine($"{c} & {a} are same and greater than {b}");
            }
        }
        else
        {
            if(b > c)
            {
                Console.WriteLine($"{b} is greater than {a} and {c}");
            }
            else if (b < c)
            {
                Console.WriteLine($"{c} is greater than {a} and {b}");
            }
            else
            {
                Console.WriteLine($"{c} & {b} are same and greater than {a}");
            }

        }*/

        /*//int result = a > b ? a : b;       //normaly ternary operator use
        //int result = a > b ? a > c ? a :c :b >c ? b :c;             //complex ternary operator use
        int result = (a > b) ? (a > c ? a : c) : (b > c ? b : c);      //complex to normaly ternary operator convert using ()
        Console.WriteLine($"{ result} is bigger number");*/

        /*// if number is divisble by 3 print THREE/ by 5 print FIVE/ by 3 & 5 both print THREEFIVE

        Console.WriteLine("please enter number");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine("THREEFIVE");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("THREE");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("FIVE");
        }
        else
        {
            Console.WriteLine("NOT DIVIDED BY 3 & 5 ");
        }*/


        Console.WriteLine("Please enter city");
        string city = Console.ReadLine();

        switch (city.ToUpper())
        {
            case "MUMBAI":
                Console.WriteLine("MUMBAI : SAGAR");
                break;
            case "PUNE":
                Console.WriteLine("PUNE : ATUL");
                break;
            default:
                Console.WriteLine("UNKNOWN CITY");
                break;
        }

        Console.ReadLine();
    }
}