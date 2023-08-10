using System.Linq;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        //List<int> evenNumbers = new List<int>();
        //foreach (int item in numbers)
        //{
        //    if (item % 2 == 0)
        //    {
        //        evenNumbers.Add(item);
        //    }
        //}

        //var evenNumbers = from item in numbers
        //                  select item;

        //var evenNumbers = from item in numbers
        //                  where item % 2 == 0
        //                  select item;

        var evenNumbers = numbers.Where(i => i % 2 == 0);

        foreach (int item in evenNumbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        // 01 02 03 04 05 06

        var numFormat = from i in numbers
                        select "0" + i.ToString();

        foreach (string item in numFormat)
        {
            Console.Write($"{item} ");
        }


        Console.ReadLine();
    }
}

