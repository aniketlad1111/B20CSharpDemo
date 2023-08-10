class Program
{
    static void Main()
    {
        #region Simple type collection

        //List<int> numbers = new List<int>() { 1, 45, 21, 53, 12 };
        //Console.WriteLine("*** All Items ***");
        //foreach (int num in numbers)
        //{
        //    Console.Write($"{num} ");
        //}
        //Console.WriteLine();

        //numbers.Reverse();
        //Console.WriteLine("*** All Items After Reverse() ***");
        //foreach (int num in numbers)
        //{
        //    Console.Write($"{num} ");
        //}
        //Console.WriteLine();

        //IOrderedEnumerable<int> result = numbers.OrderBy(i => i);
        //Console.WriteLine("*** All Items After OrderBy(i => i) ***");
        //foreach (int num in result)
        //{
        //    Console.Write($"{num} ");
        //}
        //Console.WriteLine();

        //IOrderedEnumerable<int> result = numbers.OrderByDescending(i => i);
        //Console.WriteLine("*** All Items After OrderByDescending(i => i) ***");
        //foreach (int num in result)
        //{
        //    Console.Write($"{num} ");
        //}
        //Console.WriteLine();

        #endregion Simple type collection

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

        //var result1 = students.OrderBy(s => s.City);
        //Console.WriteLine("*** All Items After OrderBy(s => s.City) ***");
        //foreach (Student s in result1)
        //{
        //    Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
        //        $"City : {s.City} Age : {s.Age}");
        //}

        //// var result2 = students.OrderBy(s => s.City).ThenBy(s => s.Name);
        //var result2 = students.OrderBy(s => s.City).ThenByDescending(s => s.Name);
        //Console.WriteLine("*** All Items After OrderBy(s => s.City).ThenBy(s => s.Name) ***");
        //foreach (Student s in result2)
        //{
        //    Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
        //        $"City : {s.City} Age : {s.Age}");
        //}

        List<int> numbers = new List<int>() { 45, 12, 10, 8, 17 };
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        List<string> names = new List<string>()
        { "Vishal", "Dipak", "Shital", "Pooja"};
        names.Sort();
        foreach (string num in names)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        //students.Sort();
        //Console.WriteLine("*** All Items After Sort() ***");
        //foreach (Student s in students)
        //{
        //    Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
        //        $"City : {s.City} Age : {s.Age}");
        //}

        //// students.Sort(new StudentHelper());
        //students.Sort(0, 3, new StudentHelper());
        //Console.WriteLine("*** All Items After Sort(new StudentHelper()) ***");
        //foreach (Student s in students)
        //{
        //    Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
        //        $"City : {s.City} Age : {s.Age}");
        //}


        students.Sort((x, y) => x.City.CompareTo(y.City));
        Console.WriteLine("*** All Items After Sort((x, y) => x.City.CompareTo(y.City)) ***");
        foreach (Student s in students)
        {
            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} " +
                $"City : {s.City} Age : {s.Age}");
        }

        Console.ReadLine();
    }
}

class Student : IComparable
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public string City { get; set; }

    public int Age { get; set; }

    public int CompareTo(object? obj)
    {
        Student s = obj as Student;

        return this.Age.CompareTo(s.Age);

        //if(this.Age > s.Age)
        //{
        //    return 1;
        //}
        //else if (this.Age < s.Age)
        //{
        //    return -1;
        //}
        //else
        //{
        //    return 0;
        //}
    }
}

class StudentHelper : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        return x.Name.CompareTo(y.Name);
    }
}