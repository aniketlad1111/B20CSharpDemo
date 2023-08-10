class Program
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine(date);

        //date = DateTime.Today;
        //Console.WriteLine(date);

        string onlyDate = date.ToLongDateString();
        Console.WriteLine(onlyDate);

        onlyDate = date.ToShortDateString();
        Console.WriteLine(onlyDate);

        string onlyTime = date.ToLongTimeString();
        Console.WriteLine(onlyTime);

        onlyDate = date.ToString("dd/MM/yyyy");
        Console.WriteLine(onlyDate);

        onlyDate = date.ToString("dd/MMM/yyyy");
        Console.WriteLine(onlyDate);

        onlyDate = date.ToString("dd MMM yyyy");
        Console.WriteLine(onlyDate);

        onlyDate = date.ToString("MMMM yyyy");
        Console.WriteLine(onlyDate);

        // refer : https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

        //Student s1 = new Student();
        //s1.FirstName = "Anil";
        //s1.LastName = "Rathod";
        //s1.PrintFullName();

        //Student s2 = new Student("Suraj", "Chavhan");
        //s2.PrintFullName();

        Console.ReadLine();
    }

    static void Print(Person person)
    {

    }
}

// class Student
struct Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //public Student()
    //{
    //    //FirstName = "First Name";
    //    //LastName = "Last Name";
    //}

    //public Student(string fn, string ln)
    //{
    //    FirstName = fn;
    //    LastName = ln;
    //}

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}");
    }
}

//class Intern : Student
//{

//}

struct Person
{
    public int id;
    public string name;
    public string gender;
    public string email;
    public string adhaar;
}