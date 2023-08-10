using System.ComponentModel;

class program
{
    static void Main()
    {
        short v1 = 10;
        int v2 = v1;   // short => int
        Console.WriteLine(v2);

        short v3 = (short)v2;
        Console.WriteLine(v3);

        float v4 = v2; // int => float
        Console.WriteLine(v4);

        int v5 = (int)v4;  // float => int
        Console.WriteLine(v5);

        string v6 = "100";   // int v7 = v6; // string => int
        int v7 = Convert.ToInt32(v6);
        Console.WriteLine(v7);  // 100

        v6 = "abc";
        int v8;
        bool status = int.TryParse(v6, out v8);
        Console.WriteLine(status);
        Console.WriteLine(v8);

        string v9 = "true";
        bool v10 = bool.Parse(v9);  // string = > bool
        Console.WriteLine(v10);

        Console.ReadLine();
    }
}