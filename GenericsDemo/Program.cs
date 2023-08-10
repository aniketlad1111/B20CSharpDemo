using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        //Calculator c1 = new Calculator();
        //bool b1 = c1.AreEqual(10 , 10);
        //Console.WriteLine(b1);

        //b1= c1.AreEqual("ABC" ,"ABC" );
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual(10.5f , 10.5f);
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual(456m , 785m);
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual(10, "Vishal");
        //Console.WriteLine(b1);

        //Calculator c1= new Calculator();
        //bool b1 = c1.AreEqual<int>(10, 10);
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual<string>("A","B");
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual<string>("A", 10);
        //Console.WriteLine(b1);

        //c1.Add<string>("A","B"); // AB
        //c1.Add<int>(10, 10); // 20
        //c1.Add(10.5f, 10.5f); // 21

        // Student s1 = new Student();
        Student<string, int, string> s1 = new Student<string, int, string>();
        s1.PrintA("HELLO");

        string result = s1.PrintB("Vishal");
        Console.WriteLine(result);

        Student<Calculator, string, decimal> s2 =
            new Student<Calculator, string, decimal>();

        s2.PrintA(new Calculator());

        Calculator c1 = new Calculator();
        long r1 = c1.GetSum<int, long>(10, 10);
        Console.WriteLine(r1);



        Console.ReadLine();
    }
}

class Calculator
{
    //public bool AreEqual(int a, int b)
    //{
    //    return a.Equals(b);
    //}

    //public bool AreEqual(string a, string b)
    //{
    //    return a.Equals(b);
    //}

    //public bool AreEqual(float a, float b)
    //{
    //    return a.Equals(b);
    //}

    //public bool AreEqual(object a, object b)
    //{
    //    return a.Equals(b);
    //}

    public bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }

    public void Add<T>(T a ,T b)
    {
        dynamic n1 = a;
        dynamic n2 = b;

        Console.WriteLine(n1 + n2);
    }

    public TOut GetSum<Tin, TOut>(Tin a, Tin b)
    {
        dynamic n1 = a;
        dynamic n2 = b;

        return n1 + n2;
    }
}

class Student<T1, T2, TResult>
{
    public void PrintA(T1 a)
    {
        Console.WriteLine(a);
    }

    public TResult PrintB(T1 a)
    {
        dynamic result = $"Welcome, {a}";
        return result;
    }
}

interface IA<T>
{
    void Print(T a);
}
}