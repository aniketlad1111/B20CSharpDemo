using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        List<int> numbers= new List<int>() { 1,2,3};

        //var result = numbers.Count();
        //Console.WriteLine(result);

        //result= numbers.Count(i => i % 2 == 0);
        //Console.WriteLine(result);

        //long result1 = numbers.LongCount();
        //Console.WriteLine(result1);

        //result = numbers.Min();
        //Console.WriteLine(result);

        //result = numbers.Max();
        //Console.WriteLine(result);

        //result = numbers.Sum();
        //Console.WriteLine(result);

        //double result2 = numbers.Average();
        //Console.WriteLine(result2);

        bool b1 = numbers.Contains(1);
        Console.WriteLine(b1);

        bool b2 = numbers.Contains(100);
        Console.WriteLine(b2);

        List<Student> students = new List<Student>()
        {
        new Student(){RollNumber = 1, Name = "Vishal", City = "Pune", Age = 25},
        new Student(){RollNumber = 2, Name = "Mahesh", City = "Mumbai", Age = 20},
        new Student(){RollNumber = 3, Name = "Shital", City = "Mumbai", Age = 25},
        new Student(){RollNumber = 4, Name = "Snehal", City = "Pune", Age = 22},
        new Student(){RollNumber = 5, Name = "Dipak", City = "Pune", Age = 21}
        };

        Student s1 = new Student()
        { RollNumber = 1, Name = "Vishal", City = "Pune", Age = 25 };

        b1 = students.Contains(s1, new StudentHelper());
        Console.WriteLine(b1);

        b1 = numbers.All(i => i > 1);
        Console.WriteLine(b1);

        b1 = numbers.Any(i => i > 1);
        Console.WriteLine(b1);


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

class StudentHelper : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.RollNumber.Equals(y.RollNumber) &&
            x.Name.Equals(y.Name) &&
            x.City.Equals(y.City) &&
            x.Age.Equals(y.Age);
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        return obj.RollNumber.GetHashCode() ^
            obj.Name.GetHashCode() ^ 
            obj.City.GetHashCode();
        obj.Age.GetHashCode();
    }
}
