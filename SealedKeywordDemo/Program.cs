class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Print();

        Employee e = new Employee();
        e.Print();
        // e.PrintA();

        PermanentEmployee pe = new PermanentEmployee();
        pe.Print();

        Console.ReadLine();
    }
}

// public sealed class Person
public class Person
{
    public virtual void Print()
    {
        Console.WriteLine("Person");
    }

    public void PrintA()
    {
        Console.WriteLine("Person PrintA()");
    }
}

public class Employee : Person
{
    // public sealed override void Print()
    public override void Print()
    {
        Console.WriteLine("Employee");
    }
}

public class PermanentEmployee : Employee
{
    public override void Print()
    {
        Console.WriteLine("PermanentEmployee");
    }
}
