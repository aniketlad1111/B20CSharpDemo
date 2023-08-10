using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {

        //string n = "100";
        //int i;
        //bool b = int.TryParse(n, out i);


        /*string name = "Main";
        Console.WriteLine(name); //Main

        PrintA(name);
        Console.WriteLine(name); //Main */

        /*string name = "Main";
        Console.WriteLine(name); //Main

        PrintA(ref name);
        Console.WriteLine(name); //PrintA */

        /*int a =10 ,b = 5, add, sub, mul, div;
        operation(a,b,out add,out sub,out mul,out div);
        Console.WriteLine($"Addition : {add}");
        Console.WriteLine($"Substraction : {sub}");
        Console.WriteLine($"Multiplication : {mul}");
        Console.WriteLine($"Division : {div}");*/

        int[] n1 = new int[] {10, 20, 30};
        PrintSum(n1);  //60

        PrintSum(new int[] { 10, 20, 30 }); //60

        int[] n2 = null;
        PrintSum(n2);  //Empty Array

        PrintSum(null);  //Empty Array

        PrintSum(10, 20, 30, 40); //100

        PrintSum();  //Empty Array

        PrintSum1(1, 10, 20, 30);

        Console.ReadLine();
    }

    /*static void PrintA(string name)
    {
        //name = "PrintA";
    }*/

    /*static void PrintA(ref string name)
    {
        name = "PrintA";
    }*/

    /*static void operation(int a,int b,
        out int add, out int sub, out int mul, out int div)
    {
        add = a + b;
        sub = a - b;
        mul = b * a;
        div = a / b;
    }*/

    static void PrintSum(params int[] numbers)
    {
        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
               sum += numbers[i]; 
            }
            Console.WriteLine($"Sum : {sum}");
        }
        else
        {
            Console.WriteLine("Empty Array");
        }
    }

    static void PrintSum1(int a, int b, params int[] numbers)
    {

    }
}