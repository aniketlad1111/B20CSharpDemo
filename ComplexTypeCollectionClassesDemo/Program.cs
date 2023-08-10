using System.Collections;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        //Student s1 = new Student()
        //{ RollNumber = 1, Name = "Vishal", Gender = "Male", City = "Pune" };

        //List<Student> students = new List<Student>();
        //students.Add(s1);
        //students.Add(new Student()
        //{ RollNumber = 2, Name = "Shital", Gender = "Female", City = "Pune" }
        //);
        //students.Add(new Student()
        //{ RollNumber = 3, Name = "Mahesh", Gender = "Male", City = "Mumbai" }
        //);

        //List<Student> students = new List<Student>()
        //{
        //new Student(){ RollNumber = 1, Name = "Vishal", Gender = "Male", City = "Pune"},
        //new Student(){ RollNumber = 2, Name = "Mahesh", Gender = "Male", City = "Mumbai"},
        //new Student(){ RollNumber = 3, Name = "Shital", Gender = "Female", City = "Pune"}
        //};

        ////ArrayList students = new ArrayList()
        ////{
        ////new Student(){ RollNumber = 1, Name = "Vishal", Gender = "Male", City = "Pune"},
        ////new Student(){ RollNumber = 2, Name = "Mahesh", Gender = "Male", City = "Mumbai"},
        ////new Student(){ RollNumber = 3, Name = "Shital", Gender = "Female", City = "Pune"}
        ////};

        //foreach (Student item in students)
        //{
        //    Console.WriteLine($"RollNumber : {item.RollNumber}" +
        //        $" Name : {item.Name} Gender : {item.Gender}" +
        //        $" City : {item.City}");
        //}

        //Student s1 = new Student()
        //{ RollNumber = 1, Name = "Vishal", Gender = "Male", City = "Pune" };

        //if (students.Contains(s1, new StudentHelper()))
        //{
        //    Console.WriteLine("Exists");
        //}
        //else
        //{
        //    Console.WriteLine("Not Exists");
        //}

        //Student s1 = new Student()
        //{ RollNumber = 1, Name = "Vishal", Gender = "Male", City = "Pune" };
        //Student s2 = new Student()
        //{ RollNumber = 2, Name = "Mahesh", Gender = "Male", City = "Mumbai" };
        //Student s3 = new Student()
        //{ RollNumber = 3, Name = "Shital", Gender = "Female", City = "Pune" };

        ////Dictionary<int, Student> students = new Dictionary<int, Student>();
        ////students.Add(s1.RollNumber, s1);
        ////students.Add(s2.RollNumber, s2);
        ////students.Add(s3.RollNumber, s3);

        //Hashtable students = new Hashtable();
        //students.Add(s1.RollNumber, s1);
        //students.Add(s2.RollNumber, s2);
        //students.Add(s3.RollNumber, s3);

        //foreach (DictionaryEntry item in students)
        //{
        //    var value = (Student) item.Value;
        //    Console.WriteLine($"Key : {item.Key}");
        //    Console.WriteLine($"RollNumber : {value.RollNumber}" +
        //        $" Name : {value.Name} Gender : {value.Gender}" +
        //        $" City : {value.City}");
        //}

        //Student s = (Student) students[2];
        //Console.WriteLine($"RollNumber : {s.RollNumber}" +
        //        $" Name : {s.Name} Gender : {s.Gender}" +
        //        $" City : {s.City}");


        // Person p = new Student() { Name = "Vishal" };
        // Person p = null;
        Person p = new Employee();

        // Student s = (Student)p; // thrown error
        Student s = p as Student;

        Console.WriteLine(s?.Name);

        if (p is Student)
        {
            Console.WriteLine("Cast is possible");
        }
        else
        {
            Console.WriteLine("Cast is not possible");
        }


        Console.ReadLine();
    }
}

class Person { }

class Student : Person
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public string Gender { get; set; }

    public string City { get; set; }

    //public override bool Equals(object? obj)
    //{
    //    Student s = (Student)obj;

    //    return this.RollNumber.Equals(s.RollNumber) &&
    //        this.Name.Equals(s.Name) &&
    //        this.Gender.Equals(s.Gender) &&
    //        this.City.Equals(s.City);
    //}
}

class StudentHelper : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        return x.RollNumber.Equals(y.RollNumber) &&
            x.Name.Equals(y.Name) &&
            x.Gender.Equals(y.Gender) &&
            x.City.Equals(y.City);
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        return obj.RollNumber.GetHashCode() ^
            obj.Name.GetHashCode() ^
            obj.Gender.GetHashCode() ^
            obj.City.GetHashCode();
    }
}

class Employee : Person { }