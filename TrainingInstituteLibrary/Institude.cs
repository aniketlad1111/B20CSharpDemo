// public delegate bool DiscountCriteria(Student student);

public class Institute
{
    public string Name { get; set; }
    public const int Fees = 40000;

    Student[] students;

    public Institute(string name, Student[] students)
    {
        this.Name = name;
        this.students = students;
    }

    public void InstituteDetails()
    {
        Console.WriteLine($"Institute Name : {Name}");
    }

    public void AllStudents()
    {
        if (students != null && students.Length > 0)
        {
            Console.WriteLine($"Total Students : {students.Length}");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"RollNumber : {students[i].RollNumber}" +
                    $" Name : {students[i].Name} City : {students[i].City}");
            }
        }
        else
        {
            Console.WriteLine($"No Students In {Name} Institute");
        }
    }

    // public void DiscountedStudents(DiscountCriteria del)
    public void DiscountedStudents(Predicate<Student> del)
    {
        if (students != null && students.Length > 0)
        {
            Console.WriteLine("All Discounted Students List");
            for (int i = 0; i < students.Length; i++)
            {
                // if (students[i].City == "Mumbai")
                if (del(students[i]))
                {
                    Console.WriteLine($"RollNumber : {students[i].RollNumber}" +
                    $" Name : {students[i].Name} City : {students[i].City}");
                }
            }
        }
        else
        {
            Console.WriteLine($"No Students In {Name} Institute For Discount");
        }
    }
}