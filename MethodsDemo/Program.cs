/*class Program
{
    static void Main()
    {
        Console.WriteLine("Main() Starts");

        PrintA();

        string r1 = PrintB();
        Console.WriteLine(r1);

        PrintC("Vishal");

        int r2 = PrintD("Vishal");
        Console.WriteLine(r2);  //6

        Console.WriteLine("Main() End");
        Console.ReadLine(); 
    }

    // method does not have return type and parameters
    static void PrintA()
    {
        Console.WriteLine("PrintA() Method");
    }

    // method has return type and no parameters
    static string PrintB()
    {
        Console.WriteLine("PrintB() Method");
        return "HELLO from PrintB()";
    }

    // method has no return type and has parameters
    static void PrintC(string name)
    {
        Console.WriteLine($"Hello , {name}");
    }

    // method has return type and has parameters
    static int PrintD(string name) 
    {
        return name.Length;
    }
}*/

class Program
{
    // Main() method = Calling Method
    static void Main()
    {
        string r1 = PrintA("Vishal");  // Vishal = method argument
        Console.WriteLine(r1);

        //PrintB(false);
        PrintB(true);

        Console.ReadLine();
    }

    // PrintA() method = Called Method
    static string PrintA(string name)  // name - method parameter
    {
        return "GOOD MORNING ," + name;
    }

    static void PrintB(bool b)
    {
        if(!b)
        {
            return;
        }
        Console.WriteLine("Execute code from PrintB() Method");
    }
}
