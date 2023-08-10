class Program
{
    static void Main()
    {
        Action<string> d1 = s => Console.WriteLine($"Hello, {s}");
        d1("Vikas");

        Action<string, string> d2 = (s1, s2) => Console.WriteLine($"{s1} {s2}");
        d2("Vikas", "Ade");

        Action<int, int> d3 = (i1, i2) => Console.WriteLine(i1 + i2);
        d3(10, 10);

        Predicate<string> d4 = s => s.Equals("Vishal");
        bool b1 = d4("Vishal");
        Console.WriteLine(b1);  // true

        b1 = d4("Vikas");
        Console.WriteLine(b1); // false

        // Func<string>
        // public delegate TResult Func<out TResult>();

        // Func<int, string>
        // public delegate TResult Func<in T, out TResult>(T arg);

        Func<string, string, string> d5 = (s1, s2) => s1 + " " + s2;
        // Func<string, string, string> d5 = (s1, s2) => s1 == s2;
        string r1 = d5("Atul", "Sahane");
        Console.WriteLine(r1);

        Func<int, int, int> d6 = (i1, i2) => i1 + i2;
        int r2 = d6(10, 20);
        Console.WriteLine(r2);

        Console.ReadLine();
    }
}