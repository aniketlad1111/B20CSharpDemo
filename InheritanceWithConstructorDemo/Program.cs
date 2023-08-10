class Program
{
    static void Main()
    {

        // Person p1 = new Person();
        // Employee e1 = new Employee();
        // Person p2 = new Employee();

        // Employee e1 = new Employee("GOOD MORNING !!!");

        Employee e1 = new Employee("GOOD MORNING !!!", 1000);
        e1.Print();


        Console.ReadLine();
    }
}

class Mammals
{
    public Mammals()
    {
        Console.WriteLine("Mammals() Called");
    }
}

class Person //: Mammals
{
    public string Name = "Person";
    /*public Person()
    {
        Console.WriteLine("Person() called");
    }*/

    public Person(string Message)
    {
        Console.WriteLine("Person(string Message)");
    }

    public Person(int num)
    {
        Console.WriteLine($"Person(int num) : {num} Called");
    }
}

class Employee : Person
{
    public string Name = "Person";
    /*public Employee()
    {
        Console.WriteLine("Employee() called");
    }*/

    public Employee(string Message) : base(10)
    {
        Console.WriteLine("Employee(string Message)");
    }

    public Employee(string message, int num) : base(num)
    {
        Console.WriteLine("Employee(string message, int num) Called");
    }

    public void Print()
    {
        // Console.WriteLine(Name); // Employee
        // Console.WriteLine(this.Name); // Employee
        Console.WriteLine(base.Name); // Person
    }
}
