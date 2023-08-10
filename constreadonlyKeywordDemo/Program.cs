using static System.Console;

class Program
{
    static void Main()
    {
        // WriteLine(Student.CourseName);

        Student s1 = new Student();
        s1.FirstName = "Anil";
        s1.LastName = "Rathod";
        // s1.CourseName = "Dot Net";
        s1.Print();

        // Student.CourseName = "Java";

        Student s2 = new Student();
        s2.FirstName = "Anil";
        s2.LastName = "Pawar";
        // s2.CourseName = "Java";
        s2.Print();

        Student s3 = new Student("Python");
        s3.FirstName = "Akash";
        s3.LastName = "Ade";
        s3.Print();

        ReadLine();
    }
}

class Student
{
    public string FirstName;
    public string LastName;
    // public static string CourseName = "Dot Net";
    // public const string CourseName = "Dot Net";
    public readonly string CourseName = "Dot Net";
    // public static readonly string CourseName = "Dot Net";

    public Student()
    {
        CourseName = "Java";
    }
    public Student(string cn)
    {
        CourseName = cn;
    }

    public void Print()
    {
        //CourseName = "Data Science";

        WriteLine($"{CourseName} : {FirstName} {LastName}");
    }
}
