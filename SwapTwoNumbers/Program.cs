using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Please Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        IsPrime(num);


        /*Console.WriteLine("Please enter first number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter secound number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"first number : {a} \nsecond number : {b}");*/

        /*int c = a;  //third variable
         a = b;
         b = c;*/

        /*a = a + b; 
        b = a - b;
        a = a - b;*/

        /*Console.WriteLine($"first number : {a} \nsecond number : {b}");*/




        Console.ReadLine();
    }

    static void IsPrime(int num)
    {
        bool isPrime = false;

        Console.Write($"{num} is divisible by ");
        for (int i = 2; i < num / 2; i++)
        {
            if (num % i == 0)
            {
                Console.Write($" {i},");
                isPrime = true;
                // break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{num} not PRIME NUMBER");
        }
        else
        {
            Console.WriteLine($"{num} PRIME NUMBER");
        }
    }
}
