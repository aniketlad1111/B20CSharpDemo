class Program
{
    static void Main()
    {
        int a = 10;
        //int b = a;
        int b = 10;

        int c = a + b;
        Console.WriteLine(c);

        if (a == b)
        {
            Console.WriteLine("a & b are EQUAL");
        }
        else
        {
            Console.WriteLine("a & b are EQUAL");
        }

        string s1 = "Akash";
        //string s2 = s1;
        string s2 = "Akash";

        string s3 = s1 + s2;
        Console.WriteLine(s3);

        if (s1 == s2)
        {
            Console.WriteLine("s1 & s2 are EQUAL");
        }
        else
        {
            Console.WriteLine("s1 & s2 are NOT EQUAL");
        }

        Student ss1 = new Student("Anil", "Rathod");
        //Student ss2 = ss1;
        Student ss2 = new Student("Anil", "Rathod");

        Student ss3 = ss1+ ss2;
        Console.WriteLine($"{ss3.FirstName} , {ss3.LastName}");

        if (ss2 == ss1)
        {
            Console.WriteLine("ss1 & ss2 are EQUAL");
        }
        else
        {
            Console.WriteLine("ss1 & ss2 are NOT EQUAL");
        }
        

        Console.ReadLine();
    }
}

class Student
{
    public string FirstName;
    public string LastName; 
    public Student(string fn , string ln)
    {
        FirstName= fn;
        LastName= ln;
    }

    public static bool operator ==(Student s1, Student s2)
    {
        return s1.FirstName == s2.FirstName && s1.LastName == s2.LastName;
    }
    public static bool operator !=(Student s1, Student s2)
    {
        return s1.FirstName != s1.FirstName && s1.LastName != s2.LastName;
    }

    public static Student operator +(Student s1, Student s2)
    {
        Student s = new Student(
            s1.FirstName + "," + s2.FirstName ,
            s1.LastName + ","+ s2.LastName);
        return s;
    }
}