string result = Get();
Console.WriteLine(result);

string Get()
{
    string result = string.Empty;
    // return "Hello";
    try
    {
        result = "Try";
        // return result;
        // return "Try";
    }
    catch
    {
        result = "Catch";
        // return result;
        // return "Catch";
    }
    finally
    {
        Console.WriteLine("Finally block executed");
        result = "Finally";
        // return "Finally";
    }
    return result;
}