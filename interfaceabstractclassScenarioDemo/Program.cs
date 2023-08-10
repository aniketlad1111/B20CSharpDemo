class Program
{
    static void Main()
    {



        Console.ReadLine();
    }
}

interface IA
{
    void PrintA();
}

interface IB : IA
{
    void PrintB();
}

abstract class A : IB
{
    public abstract void PrintA();
    public abstract void PrintB();
}

class B
{

}

// IA, IB, B 
// class C : B, IA, IB
//class C : A, B, IA, IB
//{

//}
