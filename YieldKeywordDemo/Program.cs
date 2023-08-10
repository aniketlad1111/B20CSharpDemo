using System.Collections;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        foreach (int num in GetEven(numbers))
        {
            Console.Write($"{num} ");
        }

        //Customer c1 = new Customer();
        //foreach (var i in c1)
        //{

        //}

        Console.ReadLine();
    }

    static IEnumerable<int> GetEven(List<int> numbers)
    {
        // List<int> result = new List<int>();

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                // result.Add(num);
                yield return num;
            }
        }

        //  return result;
    }
}


class Customer : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}