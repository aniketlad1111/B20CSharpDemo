// Employee class is inheriting Person class
// Employee class = Child Class / Derived Class
// Person class = Parent Class / Base Class
class Employee : Person
{
    public int EmployeeId;
    public string CompanyName;

    public new void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName} - EMPLOYEE");
    }

    public void Details()
    {
        Console.WriteLine($"**** Employee Details *****\n" +
            $"First Name : {FirstName}" +
            $" Last Name : {LastName}\n" +
            $"Employee Id : {EmployeeId} Company Name : {CompanyName}");
    }
}
