class Program
{
    static void Main()
    {

        //string[] names = new string[] { "Vishal", "Mahesh", "Dipak" };
        //string n = names[1];
        //Console.WriteLine(n); // Mahesh

        //names[1] = "Shital";
        //n = names[1];
        //Console.WriteLine(n); // Shital

        Student[] students = new Student[]
        {
            new Student(){ RollNumber = 101, Name = "Vishal", City = "Pune"},
            new Student(){ RollNumber = 102, Name = "Mahesh", City = "Mumbai"},
            new Student(){ RollNumber = 103, Name = "Dipak", City = "Pune"},
            new Student(){ RollNumber = 104, Name = "Shital", City = "Pune"},
            new Student(){ RollNumber = 105, Name = "Snehal", City = "Mumbai"}
        };

        Institute i1 = new Institute(students);

        string name = i1[105]; // reading value
        Console.WriteLine(name); // Snehal

        i1[105] = "Priyanka"; // setting value
        name = i1[105]; // reading value
        Console.WriteLine(name); // Priyanka

        Student s = i1["Vishal"];
        Console.WriteLine($"{s.RollNumber} : {s.Name} : {s.City}");

        Console.ReadLine(); 
    }
}

class Student
{
    public int RollNumber;
    public string Name;
    public string City;
}

class Institute
{
    public string InstituteName { get; set; }
    private Student[] _students;

    public Institute(Student[] students)
    {
        _students = students;
    }

    public string this[int rn]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    return _students[i].Name;
                }
            }
            return $"Student Not Found by Roll Number {rn}";
        }

        set
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    _students[i].Name = value;
                }
            }
        }
    }

    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name == name)
                {
                    return _students[i];
                }
            }

            return null;
        }
    }
}