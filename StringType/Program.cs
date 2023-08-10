class program
{
    static void Main()
    {
        String firstName = "Anil";
        Console.WriteLine(firstName);

        String firstNameIsUpper = firstName.ToUpper();
        Console.WriteLine(firstNameIsUpper);           //upper case method 

        String firstNameIsLower = firstName.ToLower();
        Console.WriteLine(firstNameIsLower);           //lower case method

        Console.WriteLine(firstName.ToUpper());        //upper case method in single line
        Console.WriteLine(firstName.ToLower());        //lower case method in single line

        Console.WriteLine(firstName.Length);           //count the lenght character


        firstName = "   Anil    ";
        Console.WriteLine(firstName.Trim());           //trim function use for remove space

        firstName = "\"Anil\"";
        Console.WriteLine(firstName);                  // (\) use for special character separte

        firstName = "\\Anil\\";
        Console.WriteLine(firstName);                  // (\) use for special character separte

        firstName = "Anil\nRathod";
        Console.WriteLine(firstName);                  // \n use for next line print

        firstName = "Anil\tRathod";
        Console.WriteLine(firstName);                  // \t use for 3 space

        string Filepath = "D:\\DN# 20\\C#";
        Console.WriteLine(Filepath);                   // filepath is show in console screen

        firstName = "Anil";
        string lastName = "Rathod";

        string fullName = firstName +" " + lastName;
        Console.WriteLine(fullName);                   // + operator use join two strings

        fullName = string.Concat(firstName," ", lastName);
        Console.WriteLine(fullName);                   // Concat method use to join two strings

        fullName = string.Join(',', firstName, lastName);
        Console.WriteLine(fullName);                   // join method use to join two strings

        fullName = string.Format($"Full Name = {firstName} {lastName} ");
        Console.WriteLine(fullName);                   // format method use to join two strings

        Console.WriteLine($"FullName = {firstName} {lastName}");
       
        int a = 10 , b = 10 ;
        Console.WriteLine(a+b);                        // addition of two numbers

        string n1 = a.ToString();                      // int to convert string
        string n2 = b.ToString();                      // int to convert string
        Console.WriteLine(n1+n2);                      // join two string


        Console.ReadLine();
    }
}
