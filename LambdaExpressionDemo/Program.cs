delegate void Delegate1();
delegate void Delegate2(string name);
delegate string Delegate3(string fn, string ln);

class Program
{
    static void Main()
    {
        // Delegate1 d1 = new Delegate1(PrintA);
        // Delegate1 d1 = PrintA;

        //Delegate1 d1 = delegate ()
        //{
        //    Console.WriteLine("PrintA");
        //};

        //Delegate1 d1 = () =>
        //{
        //    Console.WriteLine("PrintA");
        //};

        Delegate1 d1 = () => Console.WriteLine("PrintA");
        d1();

        //Delegate2 d2 = delegate (string n)
        //{
        //    Console.WriteLine($"Hello, {n}");
        //};

        // Delegate2 d2 = (string n) => Console.WriteLine($"Hello, {n}");

        // Delegate2 d2 = (n) => Console.WriteLine($"Hello, {n}");

        Delegate2 d2 = n => Console.WriteLine($"Hello, {n}");
        d2("Vishal");

        //Delegate3 d3 = delegate (string fn, string ln)
        //{
        //    return fn + " " + ln;
        //};

        //Delegate3 d3 = (fn, ln) => fn + " " + ln;

        Delegate3 d3 = (fn, ln) =>
        {
            string result = fn + " " + ln;
            return result;
        };

        string result = d3("Anil", "Rathod");
        Console.WriteLine(result);

        Console.ReadLine();
    }

    static void PrintA()
    {
        Console.WriteLine("PrintA");
    }
}