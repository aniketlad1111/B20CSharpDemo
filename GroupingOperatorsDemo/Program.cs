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

        // var result = students.GroupBy(s => s.Age);

        //var result = from s in students
        //             group s by s.City;

        var result = students.ToLookup(s => s.Age);

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} : {item.Count()}");
            foreach (var s in item)
            {
                Console.Write($"{s.Name} ");
            }
            Console.WriteLine();
        }

        var result1 = students.Take(2);
        Console.WriteLine("*** All Items After Take(2) ***");
        foreach (Student s in result1)
        {
            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
                $"City : {s.City} Age : {s.Age}");
        }

        var result2 = students.Skip(2);
        Console.WriteLine("*** All Items After Skip(2) ***");
        foreach (Student s in result2)
        {
            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
                $"City : {s.City} Age : {s.Age}");
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
}