class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
        new Student(){RollNumber = 1, Name = "Vishal", City = "Pune", Age = 25},
        new Student(){RollNumber = 2, Name = "Mahesh", City = "Mumbai", Age = 20},
        new Student(){RollNumber = 3, Name = "Shital", City = "Mumbai", Age = 25},
        new Student(){RollNumber = 4, Name = "Snehal", City = "Pune", Age = 22},
        new Student(){RollNumber = 5, Name = "Dipak", City = "Pune", Age = 21}
        };

        Console.WriteLine("*** All Items ***");
        foreach (Student s in students)
        {
            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
                $"City : {s.City} Age : {s.Age}");
        }

        // we are projecting list of student to list of string
        IEnumerable<string> names = students.Select(s => s.Name);
        foreach (string name in names)
        {
            Console.Write($"{name} ");
        }
        Console.WriteLine();

        // var result = students.Select(s => new { Name = s.Name, City = s.City });
        IEnumerable<Person> result = students.
            Select(s => new Person() { Name = s.Name, City = s.City });
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Name} : {item.City}");
        }

        List<string> personNames = new List<string>()
        { "Akash", "Anil", "Ayan", "Aniket" };

        IEnumerable<Person> persons = personNames.
            Select(s => new Person() { Name = s });
        foreach (var p in persons)
        {
            Console.Write($"{p.Name} ");
        }
        Console.WriteLine();


        List<Student> students1 = new List<Student>()
        {
        new Student(){RollNumber = 1, Name = "Vishal", City = "Pune", Age = 25, Subjects = new List<string>(){ "S1", "S2"} },
        new Student(){RollNumber = 2, Name = "Mahesh", City = "Mumbai", Age = 20, Subjects = new List<string>(){ "S3"} },
        new Student(){RollNumber = 3, Name = "Shital", City = "Mumbai", Age = 25, Subjects = new List<string>(){ "S4", "S5"} },
        new Student(){RollNumber = 4, Name = "Snehal", City = "Pune", Age = 22, Subjects = new List<string>(){ "S6"} },
        new Student(){RollNumber = 5, Name = "Dipak", City = "Pune", Age = 21, Subjects = new List<string>(){ "S7", "S8"} }
        };

        //IEnumerable<List<string>> studentSubjects = 
        //    students1.Select(s => s.Subjects);
        //foreach (var subjects in studentSubjects)
        //{
        //    foreach(var sub in subjects)
        //    {
        //        Console.WriteLine(sub);
        //    }
        //}

        IEnumerable<string> studentSubjects =
            students1.SelectMany(s => s.Subjects);
        foreach (var subjects in studentSubjects)
        {
            Console.WriteLine(subjects);
        }

        Console.WriteLine("Please enter comma separated names");
        string input = Console.ReadLine();

        string[] inputs = input.Split(',', '.');
        //foreach (string i in inputs)
        //{
        //    Console.WriteLine(i);
        //}

        //var items = inputs.GroupBy(s => s);
        //foreach (var item in items)
        //{
        //    Console.WriteLine($"{item.Key} : {item.Count()}");
        //}

        var items = inputs.GroupBy(s => s).
            Select(s => new { Name = s.Key, Count = s.Count() });

        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name} : {item.Count}");
        }

        Console.ReadLine();
    }
}

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int Age { get; set; }

    public List<string> Subjects { get; set; }
}

class Person
{
    public string Name { get; set; }
    public string City { get; set; }
}