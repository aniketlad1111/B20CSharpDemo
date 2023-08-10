class Program
{
    static void Main()
    {
        //Student s1 = new Student();
        //s1.FirstName = "Anil";
        //s1.LastName = "Rathod";
        //s1.Print();

        Student s1 = new Student("Anil", "Rathod");
        s1.Print();

        //Student s2 = new Student("", "");
        //if (s2.IsValidData())
        //{
        //    s1.Print();
        //}
        //else
        //{
        //    Console.WriteLine("Please check data");
        //}

        Student s3 = new Student("", "");
        s3.Print();

        Student s4 = new Student("Suraj", "Kumar");
        s4.Print();

        string fn = s4.GetFirstName();
        Console.WriteLine(fn);




        Console.ReadLine();
    }
}

class Student
{
    public string FirstName;
    public string LastName;

    public Student(string FirstName , string LastName)
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    private bool IsValidData()
    {
        return !string.IsNullOrEmpty( FirstName ); &&
               !string.IsNullOrEmpty( LastName );
    }

    public string GetFirstName()
    {
        return FirstName;
    }

    public void Print()
    {
        if (IsValidData())
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        else
        {
            Console.WriteLine("Please check data");
        }
    }
}
