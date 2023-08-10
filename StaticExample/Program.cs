class Program
{
    static void Main()
    {
        Circle c1 = new Circle();
        c1.Radius = 5;
        // c1.Pi = 3.14f;
        c1.Area();

        Circle c2 = new Circle();
        c2.Radius = 10;
        // c2.Pi = 3.14f;
        c2.Area();

        Console.ReadLine();
    }
}

class Circle
{
    public int Radius;
    static float Pi = 3.14f;

    public void Area()
    {
        Console.WriteLine($"Area of Circle having radius {Radius} : {Pi * Radius * Radius}");
    }
}
