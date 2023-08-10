delegate void Delegate1();
delegate void Delegate2(string s1, string s2);
delegate int Delegate3(string s);

class Program
{
    static void Main()
    {
        //Delegate1 d1 = delegate ()
        //{
        //    Console.WriteLine("Delegate1");
        //};

        //d1();

        //Delegate2 d2 = delegate (string s1, string s2)
        //{
        //    Console.WriteLine($"{s1} {s2}");
        //};

        //d2("Anil", "Rathod");

        //Delegate3 d3 = delegate (string s)
        //{
        //    Console.WriteLine("Delegate3");
        //    return s.Length;
        //};

        //int result = d3("Om");
        //Console.WriteLine(result);


        //Student[] students = new Student[]
        //{
        //new Student(){RollNumber = 1, Name = "Vishal", City = "Pune"},
        //new Student(){RollNumber = 2, Name = "Mahesh", City = "Mumbai"},
        //new Student(){RollNumber = 3, Name = "Shital", City = "Pune"},
        //new Student(){RollNumber = 4, Name = "Snehal", City = "Mumbai"},
        //new Student(){RollNumber = 5, Name = "Akash", City = "Satara"}

        //};

        //Institute seed = new Institute("SEED INFOTECH", students);
        //seed.InstituteDetails();
        //seed.AllStudents();
        //// seed.DiscountedStudents();
        //// DiscountCriteria del = SeedDiscountCriteria;
        //DiscountCriteria del = delegate (Student s)
        //{
        //    return s.Name.StartsWith("S");
        //};
        //seed.DiscountedStudents(del);


        Student[] students1 = new Student[]
        {
        new Student(){RollNumber = 1, Name = "Dipika", City = "Pune"},
        new Student(){RollNumber = 2, Name = "Pramod", City = "Mumbai"},
        new Student(){RollNumber = 3, Name = "Prashant", City = "Pune"}
        };

        Institute cdac = new Institute("CDAC", students1);
        cdac.InstituteDetails();
        cdac.AllStudents();
        // cdac.DiscountedStudents();
        // DiscountCriteria del1 = CdacDiscountCriteria;

        //DiscountCriteria del1 = delegate (Student s)
        //{
        //    return s.City.Equals("Pune");
        //};
        //cdac.DiscountedStudents(del1);

        //DiscountCriteria del1 = s => s.City.Equals("Pune");
        //cdac.DiscountedStudents(del1);

        cdac.DiscountedStudents(s => s.City.Equals("Pune"));

        Console.ReadLine();
    }

    //static bool SeedDiscountCriteria(Student s)
    //{
    //    return s.Name.StartsWith("S");
    //}

    //static bool CdacDiscountCriteria(Student s)
    //{
    //    return s.City.Equals("Pune");
    //}
}