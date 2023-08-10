using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region List

        //List<object> numbers = new List<object>();
        //numbers.Add(10);
        //numbers.Add(20);
        //numbers.Add("Vishal");

        //List<int> numbers = new List<int>();
        //numbers.Add(10);
        //numbers.Add(20);

        //Console.WriteLine($"Number of items : {numbers.Count}");

        //foreach (int item in numbers)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine(); // new line

        //IEnumerable<int> temp = new List<int>() { 30, 40, 50 };
        //numbers.AddRange(temp);

        //foreach (int item in numbers)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine(); // new line

        //numbers.Insert(0, 5);
        //foreach (int item in numbers)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine(); // new line

        //bool b1 = numbers.Contains(10);
        //Console.WriteLine($"Does 10 exists : {b1}"); // true

        //numbers.RemoveAll(i => i % 2 == 0);
        //foreach (int item in numbers)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine(); // new line


        #endregion List

        #region Dictionary

        //Dictionary<int, string> students = new Dictionary<int, string>();
        //students.Add(1, "Vishal");
        //students.Add(2, "Mahesh");
        //students.Add(3, "Shital");

        //Console.WriteLine($"Number of items : {students.Count}");

        //// foreach (var item in students)
        //// foreach (KeyValuePair<int, string> item in students)
        //foreach (dynamic item in students)
        //{
        //    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
        //}

        //string name = students[2];
        //Console.WriteLine(name); // Mahesh

        //students[2] = "Akash";
        //name = students[2];
        //Console.WriteLine(name); // Akash

        #endregion Dictionary

        #region Stack


        //Stack<string> history = new Stack<string>();
        //history.Push("www.google.com");
        //history.Push("C# tutorial");
        //history.Push("www.tutorialteachers.com");

        //Console.WriteLine($"Number of items : {history.Count}");
        //// string i1 = history.Pop();
        //string i1 = history.Peek();
        //Console.WriteLine(i1);

        //Console.WriteLine($"Number of items : {history.Count}");

        //i1 = history.Pop();
        //Console.WriteLine(i1);
        //Console.WriteLine($"Number of items : {history.Count}");


        #endregion Stack

        #region Queue

        //Queue<string> name = new Queue<string>();
        //name.Enqueue("Akash");
        //name.Enqueue("Shyam");
        //name.Enqueue("Shubham");

        //Console.WriteLine($"Number of items : {name.Count}");

        //// string i1 = name.Dequeue();
        //string i1 = name.Peek();
        //Console.WriteLine(i1);

        //Console.WriteLine($"Number of items : {name.Count}");


        #endregion Queue


        // Method name hints
        // if method name contains Try, Default => it handels exception
        // Peek() -> it returns value without removing it

        Console.ReadLine();
    }
}