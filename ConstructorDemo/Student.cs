class Student
{
    public string FirstName;
    public string LastName;
    public static string CourseName;

    //public Student()
    //{
    //    // Console.WriteLine("Constructor Called");
    //    FirstName = "VHAASH";
    //    LastName = "TECHNOLOGIES";
    //}

    // parameter less constructor / default constructor
    public Student()
    {
        FirstName = "VHAASH";
        LastName = "TECHNOLOGIES";
        // CourseName = "DOT NET";

        Console.WriteLine("public Student() called");
    }

    // static constructor
    // purpose: to initialize static fields
    static Student()
    {
        CourseName = "DOT NET";
        Console.WriteLine("static Student() called");
    }

    // parameterized constructor
    public Student(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }

    // parameterized constructor = copy constructor
    public Student(Student s)
    {
        FirstName = s.FirstName;
        LastName = s.LastName;
    }

    //public void Initialize(string fn, string ln)
    //{
    //    FirstName = fn; 
    //    LastName = ln;
    //}

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name : {this.FirstName} {this.LastName}");
    }
}