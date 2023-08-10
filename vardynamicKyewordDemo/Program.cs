using System.Runtime.Intrinsics;

class Program
{
    static void Main()
    {
        //int v1 = 10;
        //v1 = "Vishal";
        //char v2 = '$';
        //double v3 = 15.2;
        //Student v4 = new Student();
        //v4.Print();

        //object v1 = 10;
        //v1 = "Vishal";
        //object v2 = '$';
        //object v3 = 15.2;
        //object v4 = new Student();
        //v4.Print();

        //var v1 = new { FirstName = "Anil", LastName = "Rathod" };
        //Console.WriteLine(v1.FirstName);
        //Console.WriteLine(v1.LastName);


        //var v1 = 10; // after this line v1 will be of type int
        //// v1 = "Vishal";
        //var v2 = '$'; // after this line v2 will be of type char
        //var v3 = 15.2; // after this line v3 will be of type double
        //var v4 = new Student(); // after this line v4 will be of type Student
        //v4.Print();

        var i = 100;

        // var j = null;

        //dynamic v1 = 10;
        //v1 = "Vishal";
        //dynamic v2 = '$';
        //dynamic v3 = 15.2;
        dynamic v4 = new Student();
        v4.Print();
        //v4.MethodNahiye();

        //dynamic s1 = new Student();
        //dynamic s2 = new Student();
        //Student s3 = s1 + s2;

        //dynamic i = 10;
        //Console.WriteLine(i); // 10
        //i = "Vishal";
        //Console.WriteLine(i); // Vishal

        Console.ReadLine();
    }
}

class Student
{
    // var Name;

    public void Print()
    {
        Console.WriteLine("Student Class Print Method");
    }
}