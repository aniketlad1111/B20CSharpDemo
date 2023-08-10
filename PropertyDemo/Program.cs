class Program
{
    static void Main()
    {
        #region Code 1

        //Student s1 = new Student();
        //// setting values / assigning values/ write
        //s1.RollNumber = 1;
        //s1.Name = "Vishal";
        //s1.Passmark = 40;

        //// getting values / reading values
        //Console.WriteLine($"Roll Number : {s1.RollNumber}" +
        //    $" Name : {s1.Name} Pass Mark : {s1.Passmark}");

        #endregion Code 1

        #region Code 2

        //Student s1 = new Student();
        //// s1.RollNumber = -1; // rollnumber cannot be negative
        //// s1.SetRollNumber(-1);
        //s1.SetRollNumber(1);
        //// s1.Name = null; // if name is null then while display it should be disaply as No Name
        //// s1.SetName(null);
        //s1.SetName("Mahesh");
        //// s1.Passmark = 22; // we should not be able to change its value

        //Console.WriteLine($"Roll Number : {s1.GetRollNumber()}" +
        //    $" Name : {s1.GetName()} Pass Mark : {s1.GetPassmark()}");

        #endregion Code 2

        Student s1 = new Student();
        // setting values / assigning values/ write
        s1.RollNumber = -1;
        s1.Name = null;
        //  s1.Passmark = 40;
        s1.City = "Pune";

        // getting values / reading values
        Console.WriteLine($"Roll Number : {s1.RollNumber}" +
            $" Name : {s1.Name} Pass Mark : {s1.Passmark}" +
            $" City : {s1.City}");

        Console.ReadLine();
    }
}

//class Student
//{
//    private int _rollNumber;
//    private string _name;
//    private int _passmark = 40;

//    public int GetRollNumber()
//    {
//        return _rollNumber;
//    }

//    public void SetRollNumber(int rn)
//    {
//        if(rn > 0)
//        {
//            _rollNumber = rn;
//        }
//        else
//        {
//            Console.WriteLine("RollNumber cannot be nagative");
//        }
//    }

//    public string SetName(string name)
//    {
//        return _name;
//    }

//    public string GetName()
//    {
//        return string.IsNullOrEmpty(_name) ? "No Name" : _name;
//    }

//    public int GetPassmark()
//    {
//        return _passmark;
//    }
//}

class Student
{
    private int _rollNumber;
    private string _name;
    private int _passmark = 40;

    public int RollNumber
    {
        get
        { 
            return _rollNumber; 
        }
        set
        {
            if(value > 0)
            {
                _rollNumber = value;
            }
            else
            {
                Console.WriteLine("RollNumber cannot be nagative");
            }
        }
    }

    public string Name
    {
        get
        {
            return string.IsNullOrEmpty(_name) ? "No Name" : _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Passmark
    {
        get
        {
            return _passmark;
        }
    }

    private string _city;
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Email { get; set; }
}