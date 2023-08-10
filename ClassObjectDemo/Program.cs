class Program
{
    static void Main()
    {
        Console.WriteLine("Main Start");


        // s1 is reference variable of type Student pointing to Student object
        Student s1 = new Student();   // object/ instance
        s1.FirstName = "Anil";
        s1.LastName = "Rathod";
        s1.PrintFullName();

        Student s2= new Student();
        s2.FirstName = "Mahesh";
        s2.LastName = "Pawar";
        s2.PrintFullName();

        // object initializer 
        Student s3 = new Student() { FirstName = "Ajay", LastName = "Ade" };
        s3.PrintFullName();

        Student s4 = new Student()
        {
            FirstName = "Mayuri",
            LastName = "Deshpande",
            Mobile = 8956890522,
            Email = "mayuri@gmail.com"
        };

        s4.PrintFullName();
        s4.Details();

        Student s5 = new Student()
        {
            FirstName = "Snehal",
            LastName = "Jadhav",
            Mobile = 9527788877,
            Email = "snehal@gmail.com"
        };

        s5.Details();


        Console.WriteLine("Main End");
        Console.ReadLine();
    }
}

class Student
{
    // class fields
    public string FirstName;
    public string LastName;
    public string Email;
    public long Mobile;


    // method

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}");
    }

    public void Details()

        
    {
        PrintFullName();

        Console.WriteLine($"***** Details ******\nFirstName : {FirstName}" +
            $"\nLastName : {LastName}\n" +
            $"Mobile : {Mobile}\n" +
            $"Email : {Email}");

    }
}