class Program
{
    static void Main()
    {
        /*Student s1 = new Student() { FirstName = "Anil", LastName = "Rathod" };
        s1.PrintFullName();*/

        /*Employee e1 = new Employee();
        e1.FirstName = "Sumit";
        e1.LastName = "Godase";
        e1.EmployeeId = 100;
        e1.CompanyName = "VHAASH TECHNOLOGIES";
        e1.PrintFullName();
        e1.Details();

        Student s1 = new Student();
        s1.FirstName = "Mahesh";
        s1.LastName = "Chavhan";
        s1.RollNumber = 1;
        s1.CollegeName = "ZEAL COLLEGE";
        s1.PrintFullName();
        s1.Details();

        Celebrity c1 = new Celebrity();
        c1.FirstName = "Salman";
        c1.LastName = "Khan";
        c1.Industry = "Bollywood";
        c1.VisitExpense = 1000000;
        c1.PrintFullName();
        c1.Details();*/

        //// e1 is reference variable of type Employee pointing to Employee object
        //Employee e1 = new Employee();
        //Person p1 = new Person();

        //// p2 is reference variable of type Person pointing to Employee object
        //Person p2 = new Employee();

        //// e2 is reference variable of type Employee pointing to Person Object
        //// Employee e2 =  new Person(); // compiler error
        //Employee e2 = (Employee)new Person();

        Person p1 = new Person() { FirstName = "Anil", LastName = "Rathod" };
        p1.PrintFullName(); // Person class PrintFullName()

        Employee e1 = new Employee() { FirstName = "Anil", LastName = "Rathod" };
        e1.PrintFullName(); // Employee class PrintFullName()

        Person p2 = new Employee() { FirstName = "Anil", LastName = "Rathod" };
        p2.PrintFullName(); // Person class PrintFullName()

        Console.ReadLine();
    }
}
