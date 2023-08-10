class Program
{
    static void Main()
    {
        // Person p1 = new Person();

        Person p1 = new Employee();
        p1.Print();
        p1.PrintSpeciality();


        Person p2 = new Student();
        p2.PrintSpeciality();

        Console.ReadLine();
    }
}

public abstract class Person
{
    public abstract void PrintSpeciality();

    public void Print()
    {
        Console.WriteLine("Print()");
    }
}

public class Employee : Person
{
    public override void PrintSpeciality()
    {
        Console.WriteLine("Employee");
    }
}

public class Student : Person
{
    public override void PrintSpeciality()
    {
        Console.WriteLine("Student");
    }
}