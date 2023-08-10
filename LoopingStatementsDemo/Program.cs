using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        #region commented code

        /*int i = 1;

        do                      //do while loop statement
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 5);*/

        /*int i = 1;
        while (i <= 5)         //while loop statement
        {
            Console.WriteLine(i);
            i++;
        }*/

        /*for (int i = 1; i <= 5; i++)  //for loop statement
        {
            if (i == 3)
            {
                break;
            }

            if(i == 2 || i ==3)
            {
                //break;
                continue;
            }
            Console.WriteLine(i);
        }*/

        /*for(int i =1;i <= 5; i++)   //for loop use without break statement
        {
            Console.WriteLine(i);

            if(i == 2)
            {
                //break;
                i= 5;
            }
        }*/

        /*for(int i = 1; i <= 5; i++) 
        {
            for(int j = 1;j <= i; j++)
            {
                Console.Write("*\t");
            }
            Console.WriteLine(); //new line
        }*/


        #endregion commented code

        int totalBill = 0;
        string choice = "";
        int totalSamosa = 0, totalWadapav = 0, totalTea = 0, totalCoffee = 0;
        Console.WriteLine("------ Today's Menu -------");

        do
        {
            Console.WriteLine("Wada Pav\tSamosa\tTea\tCoffee");
            Console.WriteLine("What would you like to take?");
            string order = Console.ReadLine();

            switch (order.ToUpper())
            {
                case "WADA PAV":
                    Console.WriteLine("How many Wada Pav?");
                    int tw = int.Parse(Console.ReadLine());
                    totalWadapav += tw;
                    // totalBill += 20;
                    break;
                case "SAMOSA":
                    Console.WriteLine("How many SAMOSA?");
                    int ts = int.Parse(Console.ReadLine());
                    totalSamosa += ts;
                    // totalBill += 12;
                    break;
                case "TEA":
                    Console.WriteLine("How many TEA?");
                    int tt = int.Parse(Console.ReadLine());
                    totalTea += tt;
                    // totalBill += 10;
                    break;
                case "COFFEE":
                    Console.WriteLine("How many COFFEE?");
                    int tc = int.Parse(Console.ReadLine());
                    totalCoffee += tc;
                    // totalBill += 15;
                    break;
                default:
                    Console.WriteLine($"{order} not available");
                    break;
            }

            Console.WriteLine("Do you want to continue?");
            choice = Console.ReadLine().ToUpper();

        } while (choice == "Y" || choice == "YES");

        if (totalWadapav > 0 || totalSamosa > 0 ||
            totalTea > 0 || totalCoffee > 0)
        {
            Console.WriteLine("********* BILL RECEIPT *********");
        }

        if (totalWadapav > 0)
        {
            Console.WriteLine($"Wadapav {totalWadapav} * 20 : {totalWadapav * 20}");
            totalBill += totalWadapav * 20;
        }
        if (totalSamosa > 0)
        {
            Console.WriteLine($"Samosa {totalSamosa} * 12 : {totalSamosa * 12}");
            totalBill += totalSamosa * 12;
        }
        if (totalTea > 0)
        {
            Console.WriteLine($"Tea {totalTea} * 10: {totalTea * 10}");
            totalBill += totalTea * 10;
        }
        if (totalCoffee > 0)
        {
            Console.WriteLine($"Coffee {totalCoffee} * 15 : {totalCoffee * 15}");
            totalBill += totalCoffee * 15;
        }

        if (totalBill > 0)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Total Bill Amount : {totalBill}");
        }
        else
        {
            Console.WriteLine("NO BILL");
        }

        Console.WriteLine(); // new line
        Console.WriteLine("Thank You. Visit Again");

        Console.ReadLine();
    }
}