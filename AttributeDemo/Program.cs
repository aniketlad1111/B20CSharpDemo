using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Calculator c1 = new Calculator();
        c1.Add(10, 10);

        Console.ReadLine();
    }
}

class Calculator
{
    [Display(Name = "First Number")]
    public int Number1 { get; set; }

    [ObsoleteAttribute("Add(int,int) is outdated, Use Add(params int[])")]
    public void Add([Optional] int a, int b)
    {
        Console.WriteLine($"Addition : {a + b}");
    }

    public void Add(params int[] numbers)
    {
        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Addition : {sum}");
        }
        else
        {
            Console.WriteLine("Empty Array");
        }
    }
}