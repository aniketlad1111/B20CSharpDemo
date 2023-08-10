
class Program
{
    static void Main()
    {
        //Calculator c1 = new Calculator();
        //c1.Add(10, 10);
        //c1.Add(10, 20, 30);
        //c1.Add(10);

        //c1.Add("Vishal");

        Print(10, 10);
        short a = 10, b = 10;
        Print(a, b);

        Console.ReadLine();
    }

    static void Print(short a, short b)
    {
        Console.WriteLine("Print(short a, short b)");
    }
    static void Print(int a, int b)
    {
        Console.WriteLine("Print(int a, int b)");
    }
}

class Calculater
{
    public void Add(int a)
    {
        Console.WriteLine(a);
    }

    public void Add(out int a)
    {
        a = 10;
        Console.WriteLine(a);
    }

    //public void Add(ref int a)
    //{
    //    Console.WriteLine(a);
    //}

    //public int Add(int a)
    //{
    //    return a;
    //}



    public void Add(string a)
    {
        Console.WriteLine(a);
    }
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }

    public void Add(int a, float b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(float a, int b)
    {
        Console.WriteLine(a + b);
    }

    // public void Add(int[] numbers) { }

    public void Add(params int[] numbers) { }

}
