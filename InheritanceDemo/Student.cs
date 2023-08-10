// Student class is inheriting Person class
// Student class = Child Class / Derived Class
// Person class = Parent Class / Base Class
class Student : Person
{
    public int RollNumber;
    public string CollegeName;

    public void Details()
    {
        Console.WriteLine($"**** Student Details ****\n" +
            $"First Name : {FirstName} Last Name : {LastName}\n" +
            $"Roll Number : {RollNumber} College Name : {CollegeName}");
    }
}
