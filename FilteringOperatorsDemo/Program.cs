class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student(){ RollNumber = 1, Name = "Vishal", City = "Pune"},
            new Student(){ RollNumber = 2, Name = "Mahesh", City = "Mumbai"},
            new Student(){ RollNumber = 3, Name = "Vikas", City = "Delhi"},
            new Student(){ RollNumber = 4, Name = "Pratham", City = "Satara"},
            new Student(){ RollNumber = 5, Name = "Shital", City = "Yavatmal"}
        };

        Console.WriteLine("**** ALL STUDENTS ****");
        foreach (var item in students)
        {
            Console.WriteLine($"RollNumber : {item.RollNumber}" +
                $" Name : {item.Name} City : {item.City}");
        }

        Console.WriteLine("** Students From Pune **");
        //var puneStudents = from s in students
        //                   where s.City == "Pune"
        //                   select s;

        var puneStudents = students.Where(s => s.City == "Pune");
        foreach (var item in puneStudents)
        {
            Console.WriteLine($"RollNumber : {item.RollNumber}" +
                $" Name : {item.Name} City : {item.City}");
        }

        Console.WriteLine("** Students Name Starts With V **");
        //var vnameStudents = from s in students
        //                   where s.Name.StartsWith("V")
        //                   select s;

        IEnumerable<Student> vnameStudents =
            students.Where(s => s.Name.StartsWith("V"));
        foreach (var item in vnameStudents)
        {
            Console.WriteLine($"RollNumber : {item.RollNumber}" +
                $" Name : {item.Name} City : {item.City}");
        }

        List<Student> allStudents = new List<Student>()
        {
            new Student(){ RollNumber = 1, Name = "Vishal", City = "Pune"},
            new DotNetStudent(){ RollNumber = 2, Name = "Mahesh", City = "Mumbai"},
            new DotNetStudent(){ RollNumber = 3, Name = "Vikas", City = "Delhi"},
            new JavaStudent(){ RollNumber = 4, Name = "Pratham", City = "Satara"},
            new Student(){ RollNumber = 5, Name = "Shital", City = "Yavatmal"}
        };

        Console.WriteLine("**** ALL STUDENTS ****");
        foreach (var item in allStudents)
        {
            Console.WriteLine($"RollNumber : {item.RollNumber}" +
                $" Name : {item.Name} City : {item.City} Type : {item.StudentType}");
        }

        //var dotNetStudents =
        //     allStudents.Where(s => s.GetType().Name == "DotNetStudent");

        var dotNetStudents = allStudents.OfType<DotNetStudent>();

        Console.WriteLine("**** ALL DOT NET STUDENTS ****");
        foreach (var item in dotNetStudents)
        {
            Console.WriteLine($"RollNumber : {item.RollNumber}" +
                $" Name : {item.Name} City : {item.City} Type : {item.StudentType}");
        }

        List<object> items = new List<object>()
        { 10,20,"Vishal", 10.5f, "ABC"};

        var result1 = items.OfType<string>();
        foreach (var item in result1)
        {
            Console.Write($"{item} ");
        }

        Console.ReadLine();
    }
}

class Student
{
    public int RollNumber { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }

    public string StudentType { get; set; }

    public Student() { StudentType = "General"; }
}

class DotNetStudent : Student
{
    public DotNetStudent() { StudentType = "Dot Net"; }
}
class JavaStudent : Student
{
    public JavaStudent() { StudentType = "Java"; }
}