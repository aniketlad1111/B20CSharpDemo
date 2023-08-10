class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"You entered: {input}");

        /*if(input == 10)            //if else statement use for condition
        {
            Console.WriteLine("TEN");
        }
        else
        {
            Console.WriteLine("NOT TEN");
        }*/


        /*string result = (input == 10) ? "TEN" : "NOT TEN";   //ternary operater
        Console.WriteLine(result);*/

        /*if(input == 10)            //if else if statement use for condition
        {
            Console.WriteLine("TEN");
        }
        else if(input == 20 )
        {
            Console.WriteLine("TWENTY");
        }
        else if(input == 30 )
        {
            Console.WriteLine("THIRTY");
        }
        else
        {
            Console.WriteLine("NOT 10 20 OR 30");
        }*/

        /*switch(input)        //switch statement use for condition
        {
            case 10:
                Console.WriteLine("TEN");
                break;
            case 20:
                Console.WriteLine("TWENTY");
                break;
            case 30:
                Console.WriteLine("THIRTY");
                break;
            default:
                Console.WriteLine("NOT 10 20 OR 30");
                break;
        }*/

        if ( input % 2 == 0 )        //% mode use for remainder of division
        {
            Console.WriteLine($"{input} is EVEN number");
        }
        else
        {
            Console.WriteLine($"{input} is ODD number");
        }
            


        Console.ReadLine();
    }
}