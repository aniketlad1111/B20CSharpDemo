class Program
{
    static void Main()
    {
        Tuple<int, int, int> numbers1 = new Tuple<int, int, int>(10, 20, 30);
        Console.WriteLine(numbers1.Item2);

        Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>
            numbers2 = new
            Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>
            (1, 2, 3, 4, 5, 6, 7, numbers1);

        Console.WriteLine(numbers2.Item3); // 3
        Console.WriteLine(numbers2.Rest.Item2); // 20

        var student = StudentData();
        Console.WriteLine(student.Item2); // Vishal

        Console.ReadLine();
    }

    static Tuple<int, string, string> StudentData()
    {
        Tuple<int, string, string> s = new Tuple<int, string, string>
            (1, "Vishal", "Male");

        return s;
    }
}

