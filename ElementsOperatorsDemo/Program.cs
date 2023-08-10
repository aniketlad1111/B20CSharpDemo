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

        //// ElementAt - it return item from given index
        //// throws exception if index going outside of size

        //Student i = students.ElementAt(2);
        //Console.WriteLine($"RollNumber : {i.RollNumber}" +
        //        $" Name : {i.Name} City : {i.City}");

        //// ElementAtOrDefault - it return item from given index
        //// it handles the excpeption and returns default value
        //// this exception : throws exception if index going outside of size

        //Student i1 = students.ElementAtOrDefault(10);

        //if (i1 is not null)
        //{
        //    Console.WriteLine($"RollNumber : {i1.RollNumber}" +
        //            $" Name : {i1.Name} City : {i1.City}");
        //}

        //// First() - returns first matching item from given collection
        //// throws exception if no matching item from given collection

        //Student i = students.First();
        //Console.WriteLine($"RollNumber : {i.RollNumber}" +
        //        $" Name : {i.Name} City : {i.City}");

        //Student i1 = students.First(s => s.Name.StartsWith("V"));
        //Console.WriteLine($"RollNumber : {i1.RollNumber}" +
        //        $" Name : {i1.Name} City : {i1.City}");

        //// FirstOrDefault() - returns first matching item from given collection
        //// it handles exception and returns default value
        //// this exception : throws exception if no matching item from given collection
        //Student i2 = students.FirstOrDefault(s => s.Name.StartsWith("Z"));
        //Console.WriteLine($"RollNumber : {i2?.RollNumber}" +
        //        $" Name : {i2?.Name} City : {i2?.City}");

        ////// Last() - returns last matching item from given collection
        ////// throws exception if no matching item from given collection

        //Student i = students.Last();
        //Console.WriteLine($"RollNumber : {i.RollNumber}" +
        //        $" Name : {i.Name} City : {i.City}");

        //Student i1 = students.Last(s => s.Name.StartsWith("V"));
        //Console.WriteLine($"RollNumber : {i1.RollNumber}" +
        //        $" Name : {i1.Name} City : {i1.City}");

        ////// LastOrDefault() - returns last matching item from given collection
        ////// it handles exception and returns default value
        ////// this exception : throws exception if no matching item from given collection
        //Student i2 = students.LastOrDefault(s => s.Name.StartsWith("Z"));
        //Console.WriteLine($"RollNumber : {i2?.RollNumber}" +
        //        $" Name : {i2?.Name} City : {i2?.City}");


        //// Single() - returns first matching item from given collection
        //// it throws exception in two scenario
        /// 1 - if there are multiple matching item
        //// 2 -  if no matching item from given collection

        //Student i = students.Single();
        //Console.WriteLine($"RollNumber : {i.RollNumber}" +
        //        $" Name : {i.Name} City : {i.City}");

        Student i1 = students.Single(s => s.Name.StartsWith("M"));
        Console.WriteLine($"RollNumber : {i1.RollNumber}" +
                $" Name : {i1.Name} City : {i1.City}");

        //// SingleOrDefault() - returns first matching item from given collection
        //// it handles exception and returns default value
        //// this exception : throws exception if no matching item from given collection
        //// id does not handle exception of multiple matching element
        Student i2 = students.SingleOrDefault(s => s.Name.StartsWith("Z"));
        Console.WriteLine($"RollNumber : {i2?.RollNumber}" +
                $" Name : {i2?.Name} City : {i2?.City}");

        Console.ReadLine();
    }
}

class Student
{
    public int RollNumber { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
}
