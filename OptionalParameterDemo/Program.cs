using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        /*PrintA(10);
        PrintA();  //without passing argument
        PrintA(450);*/

        /*PrintB(10, 20); //30
        PrintB(10); //70
        PrintB(); //110 */

        /*PrintC(10 ,20);
        PrintC(b:10);
        PrintC(); */

        string result = PrintD(c: 10, b: 20, a: 50);
        Console.WriteLine(result);  //80

        Console.ReadLine();
    }

    static void PrintA(int num = 137)
    {
        Console.WriteLine($"Parameter value is : {num}");
    }

    static void PrintB(int a = 50, int b = 60)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    static void PrintC([Optional] int a, [Optional] int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    static string PrintD([Optional] int a, int b, [Optional] int c)
    {
        return $"{a} + {b} + {c} = {a + b + c}";
    }
}
