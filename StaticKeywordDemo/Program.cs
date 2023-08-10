class Program
{
    static void Main()
    {
        Student.CourseName = "Dot Net";

        Student s1 = new Student()
        {
            FirstName = "Anil",
            LastName = "Rathod",
            // CourseName = "Dot Net"
        };
        s1.Details();

        Student s2 = new Student();
        s2.FirstName = "Akash";
        s2.LastName = "Rathod";
        // s2.CourseName = "Dot Net";
        s2.Details();

        Student.Print();

        // Country c1 = new Country();

        Country.Name = "INDIA";
        Console.WriteLine(Country.Name);

        Console.ReadLine();
    }
}

class Student
{
    public string FirstName; // non static field / instance field
    public string LastName;
    public static string CourseName; // static field
    public static string TrainerName;

    // instance method can access instance as well as static members
    // instance method can call static or non static methods also
    public void Details()
    {
        // Print();

        Console.WriteLine($"****** Details *******\n" +
            $"First Name : {FirstName}\n" +
            $"Last Name : {LastName}\n" +
            $"Course Name : {CourseName}");
    }

    // static method can access only static members
    // static method can call only static methods directly
    public static void Print() // static member
    {
        Console.WriteLine("Print Method");

        // Details(); // not possible

        //// to call we need to create object
        //Student s = new Student();
        //s.Details();

        //Console.WriteLine($"****** Details *******\n" +
        //    $"First Name : {FirstName}\n" +
        //    $"Last Name : {LastName}\n" +
        //    $"Course Name : {CourseName}");
    }
}

static class Country
{
    public static string Name;

    public static void Print()
    {

    }
}