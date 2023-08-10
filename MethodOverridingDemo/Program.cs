using System;

class Program
{
    static void Main()
    {
        //Person p1 = new Person("Anil", "Rathod");
        //p1.PrintFullName(); // Person class method

        //p1 = new Employee("Rahul", "Rathod");
        //p1.PrintFullName(); // Employee class method

        //p1 = new PermanentEmployee("Atul", "Rathod");
        //p1.PrintFullName(); // PermanentEmployee class method

        Person[] persons = new Person[5];
        persons[0] = new Person("Anil", "Rathod");
        persons[1] = new Employee("Rahul", "Rathod");
        persons[2] = new PermanentEmployee("Atul", "Rathod");
        persons[3] = new Student("Nikhil", "Rathod");
        persons[4] = new Celebrity("MC", "Stan");

        for (int i = 0; i < persons.Length; i++)
        {
            persons[i].PrintFullName();
        }




        Console.ReadLine();
    }
}

class Person
{
    public string FirstName;
    public string LastName;
    public Person(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }

    public virtual void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}");
    } 
}

class Employee : Person
{
    public Employee(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : EMPLOYEE");
    }
}

class PermanentEmployee : Person
{
    public PermanentEmployee(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : Permanent Employee");
    }
}

class Student : Person
{
    public Student(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : Student");
    }
}

class Celebrity : Person
{
    public Celebrity(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : Celebrity");
    }
}