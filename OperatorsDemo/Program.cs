class program
{
    static void Main()
    {
        int v1 = 10;
        int v2 = v1;

        bool b1 = v1 == v2;    //== operator use for equation some
        Console.WriteLine($"v1 == v2 { b1}");

        v2= 20;

        b1 = v1 != v2;        //!= operator use for is not equal
        Console.WriteLine($"v1 != v2 {b1}");

        v2 = 10;
        b1 = v1 <= v2;       //<= operator use 
        Console.WriteLine($"{v1} <= {v2} = {b1}");

        b1= v1 >= v2;
        Console.WriteLine($"{v1} >= {v2} = {b1}");

        v1= 10;
        v2= 20;
        int v3 = 30;

        b1 = v1 < v2 && v2 < v3;    // && AND operator use for when all condition are true = true
        Console.WriteLine($"{v1} < {v2} && {v2} < {v3} = {b1}");

        b1 = v1 < v2 && v2> v3;    // && AND operator use for when any condition will false then will false
        Console.WriteLine($"{v1} < {v2} && {v2} > {v3} = {b1}");

        b1 = v1 < v2 || v2 > v3;   // || OR operator use for when any condition is true then true
        Console.WriteLine($"{v1} < {v2} || {v2} > {v3} = {b1}");

        b1 = v1 < v2 || v2 > v3 || v1 == v3;   // || OR operator use for when any condition is true then true
        Console.WriteLine($"{v1} < {v2} || {v2} > {v3} || {v1} == {v3} = {b1}");

        b1 = v1 < v2 || v2 > v3 && v1 == v3;   // && || OR operator use for when any condition is true then true
        Console.WriteLine($"{v1} < {v2} || {v2} > {v3} && {v1} == {v3} = {b1}");

        b1 = v2 > v3 || (v1 < v2 && v2 < v3);  // || OR operator use for when any condition is true then true but in () will be first priroty
        Console.WriteLine($"{v1} < {v2} || {v2} > {v3} && {v1} == {v3} = {b1}");


        int a = 9, b = 2;

        Console.WriteLine($"{a} + {b} = {a + b}");   // + operator
        Console.WriteLine($"{a} - {b} = {a - b}");   // - operator
        Console.WriteLine($"{a} * {b} = {a * b}");   // * operator
        Console.WriteLine($"{a} / {b} = {a / b}");   // / operator
        Console.WriteLine($"{a} % {b} = {a % b}");   // % operator

        Console.WriteLine(a); // 9
        // a = a + 5;
        a += 5;
        Console.WriteLine(a); // 14

        a *= 5;
        Console.WriteLine(a); // 70

        a++; // a = a + 1;
        Console.WriteLine(a); // 71

        a--; // a = a - 1
        Console.WriteLine(a); // 70

        // Console.WriteLine($"++a {++a}");
        Console.WriteLine($"a++ {a++}");
        Console.WriteLine(a); // 71

        Console.WriteLine($"-a {-a}"); // -71

        b1 = true;
        Console.WriteLine(b1); // true

        Console.WriteLine(!b1); // false

        Console.ReadLine();

    }
}