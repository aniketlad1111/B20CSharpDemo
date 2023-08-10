class Program
{
    static void Main()
    {
        int i = 10;
        string name = "Vishal";    // name is reference variable

        i++;
        Console.WriteLine(i); //11

        object o = i;      // int -> object
        // value type -> reference type = boxing

        Console.WriteLine(o); //11

        int j = (int) o;   // object -> int
        // reference type => value type = unboxing

        Console.WriteLine(j);  //11

        object v1 = true;
        object v2 = 100;
        object v3 = 10.5f;
        object v4 = "Vishal";
        object v5 = '$';

        float f = 10.5f;
        int k = (int) f;






        Console.ReadLine();
    }
}