class Program
{
    static void Main()
    {
        string email = null;
        //int age = null;
        Nullable<int> age = null;

        bool? b = null;

        // there is not big difference between int & int?
        // int? can store all values like int along with null

        int? x = null;
        // int y = (int) x; // int? => int

        //int y;
        //if(x != null)
        //{
        //    y = (int)x;
        //}
        //else
        //{
        //    y = 0;
        //}

        int y = x ?? 0;

        Console.WriteLine(y); // 100

        string name = "Vishal";
        Console.WriteLine(name.ToUpper()); // VISHAL

        name = null;
        Console.WriteLine(name?.ToUpper());

        string name1 = name ?? "NO NAME";
        Console.WriteLine(name1);

        Console.ReadLine();

    }
}
