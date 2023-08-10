delegate void SampleDelegate(); // declare delegate
delegate void SampleDelegateA(string s);
delegate string PrintDelegate();

class Program
{
    static void Main()
    {
        //Customer c1 = new Customer();
        //// c1.PrintA();

        //SampleDelegate d1 = new SampleDelegate(c1.PrintA); // instance of delegate
        //// d1(); // calling / invoking a delegate

        //c1.PrintB(d1);

        //SampleDelegate d1 = new SampleDelegate(Print1);
        //SampleDelegate d2 = new SampleDelegate(Print2);
        //SampleDelegate d3 = new SampleDelegate(Print3);
        //SampleDelegate d = d3 + d2 + d1 - d3;
        //d();

        //SampleDelegate d = new SampleDelegate(Print1);
        //d += new SampleDelegate(Print2);
        //d += new SampleDelegate(Print3);

        //d();

        //SampleDelegate d = Print1;
        //d += Print2;
        //d += Print3;

        //d();

        //SampleDelegateA d = Print4;
        //d("VHaaSh");

        //SampleDelegate d = Print1;
        //d += Print2;
        //d += Print3;

        // d();

        //Delegate[] delegates = d.GetInvocationList();

        //for (int i = 0; i < delegates.Length; i++)
        //{
        //    try
        //    {
        //        delegates[i].DynamicInvoke();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        PrintDelegate d = PrintA;
        d += PrintB;
        d += PrintC;

        //string result = d();
        //Console.WriteLine(result);

        Delegate[] delegates = d.GetInvocationList();
        for (int i = 0; i < delegates.Length; i++)
        {
            string result = delegates[i].DynamicInvoke().ToString();
            Console.WriteLine(result);
        }

        Console.ReadLine();
    }

    static void Print1()
    {
        Console.WriteLine("Print1() Called");
    }
    static void Print2()
    {
        throw new Exception("Genral Exception");
        Console.WriteLine("Print2() Called");
    }
    static void Print3()
    {
        Console.WriteLine("Print3() Called");
    }

    static void Print4(string s)
    {
        Console.WriteLine($"Print4(string s) : {s}");
    }

    static string PrintA()
    {
        return "PrintA";
    }
    static string PrintB()
    {
        return "PrintB";
    }
    static string PrintC()
    {
        return "PrintC";
    }
}

class Customer
{
    public void PrintA()
    {
        Console.WriteLine("PrintA()");
    }

    //public void PrintB(PrintA a)
    //{
    //    a();
    //}

    public void PrintB(SampleDelegate a)
    {
        a();
    }
}