class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>()
        { 10,4,45,12,50 };

        Console.WriteLine("** ALL ITEMS **");
        foreach (int i in numbers)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        //var result1 = numbers.Take(3);
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //// var result2 = numbers.TakeWhile(i => i > 5);
        //var result2 = numbers.TakeWhile(i => i > 1 && i < 20);
        //foreach (int i in result2)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //var result1 = numbers.Skip(3);
        //foreach (int i in result1)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //// var result2 = numbers.SkipWhile(i => i > 5);
        //var result2 = numbers.SkipWhile(i => i > 1 && i < 20);
        //foreach (int i in result2)
        //{
        //    Console.Write($"{i} ");
        //}
        //Console.WriteLine();

        //int i1 = numbers.Max();
        //Console.WriteLine($"Maximum Value = {i1}");

        //i1 = numbers.OrderByDescending(i => i).Take(2).Skip(1).First();
        //Console.WriteLine($"Second Maximum Value = {i1}");

        //i1 = numbers.OrderByDescending(i => i).Take(3).Min();
        //Console.WriteLine($"Third Maximum Value = {i1}");

        //int[] numbersArray = { 10, 4, 45, 12, 50 };
        //List<int> numbersList = numbersArray.ToList();

        ////Dictionary<int, int> numbersDictionary =
        ////    numbersList.ToDictionary(i => i);

        //Dictionary<int, int> numbersDictionary =
        //    numbersList.ToDictionary(i => numbersList.IndexOf(i));
        //foreach (var item in numbersDictionary)
        //{
        //    Console.WriteLine($"{item.Key} : {item.Value}");
        //}

        //IQueryable<int> numbersCopy = numbersList.AsQueryable();

        //        IEnumerable<int> numbers1 = new List<int>();
        IEnumerable<int> numbers1 = Enumerable.Empty<int>();
        // Console.WriteLine($"{numbers1.Count()} : {numbers1.ElementAt(0)}");

        IEnumerable<int> numbers2 = Enumerable.DefaultIfEmpty<int>(numbers1);
        Console.WriteLine($"{numbers2.Count()} : {numbers2.ElementAt(0)}");

        var numbers3 = Enumerable.Repeat<int>(5, 10);
        foreach (var item in numbers3)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        var numbers4 = Enumerable.Range(1, 10);
        foreach (var item in numbers4)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}