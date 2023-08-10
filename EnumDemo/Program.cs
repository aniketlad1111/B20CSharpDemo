class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.FirstName = "Anil";
        s1.LastName = "Rathod";
        // s1.Gender = "Male";
        // s1.Gender = 1;
        s1.Gender = Gender.Male;

        Console.WriteLine($"First Name : {s1.FirstName}\n" +
            $"Last Name : {s1.LastName}\n" +
            $"Gender : {s1.Gender}");

        Student s2 = new Student();
        s2.FirstName = "Kiran";
        s2.LastName = "Rathod";
        // s2.Gender = "Bond007";
        // s2.Gender = 2;
        s2.Gender = Gender.Female;

        Console.WriteLine($"First Name : {s2.FirstName}\n" +
            $"Last Name : {s2.LastName}\n" +
            $"Gender : {s2.Gender}");

        Student s3 = new Student();
        s3.FirstName = "Vishal";
        s3.LastName = "Pawar";
        s3.Gender = Gender.Unknown;

        Type t = Enum.GetUnderlyingType(typeof(Subject));
        Console.WriteLine($"Underlying type : {t.Name}");

        string[] names = Enum.GetNames(typeof(Subject));
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"{names[i]} ");
        }
        Console.WriteLine();

        int[] values = (int[])Enum.GetValues(typeof(Subject));
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write($"{values[i]} ");
        }


        Console.ReadLine();
    }

    static string GetGender(int gender)
    {
        switch (gender)
        {
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Unknown";
        }
    }
}


// documentation
// Male - 1, Female - 2
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // public string Gender { get; set; }
    // public int Gender { get; set; }
    public Gender Gender { get; set; }
}

enum Gender
{
    Male, Female, Unknown
}

// enum Subject : byte
enum Subject
{
    Marathi = 10, Hindi = 20, English, Mathematics, Chemistry, Physics
}