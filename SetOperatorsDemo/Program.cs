class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 11, 2, 45, 78, 53, 45 };

        Console.WriteLine("** ALL NUMBERS **");
        foreach (int i in numbers)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        //var result1 = numbers.Distinct();
        //Console.WriteLine("** ALL NUMBERS AFTER Distinct() **");
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //List<int> numbers1 = new List<int>() { 1, 2, 3 };
        //List<int> numbers2 = new List<int>() { 2, 4, 5 };

        //var result1 = numbers1.Union(numbers2);
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //var result1 = numbers1.Concat(numbers2);
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //var result1 = numbers1.Intersect(numbers2);
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //var result1 = numbers1.Except(numbers2);
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        List<int> numbers1 = new List<int>() { 1, 2, 3 };
        List<int> numbers2 = new List<int>() { 2, 1, 3 };

        numbers1.Sort();
        numbers2.Sort();

        bool b1 = numbers1.SequenceEqual(numbers2);
        Console.WriteLine(b1);

        Console.ReadLine();
    }
}