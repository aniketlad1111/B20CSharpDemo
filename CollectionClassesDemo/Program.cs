using System.Collections;

class Program
{
    static void Main()
    {
        #region ArrayList

        //// ArrayList numbers = new ArrayList();
        //ArrayList numbers = new ArrayList(3);
        //numbers.Add(10);
        //numbers.Add(20);
        //numbers.Add(30);

        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 10 20 30
        //Console.WriteLine(); // new line

        //numbers.Add(40); // it will add 40 at last in collection
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 10 20 30 40
        //Console.WriteLine(); // new line

        //ICollection temp = new ArrayList() { 50, 60 };

        //numbers.AddRange(temp); // it will add all items from temp to numbers collection
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 10 20 30 40 50 60
        //Console.WriteLine(); // new line

        //numbers.Insert(0, 5); // adds 5 at 0th index
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 5 10 20 30 40 50 60
        //Console.WriteLine(); // new line

        //ICollection temp1 = new ArrayList() { 11, 12, 15, 18 };
        //numbers.InsertRange(2, temp1);

        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 5 10 11 12 15 18 20 30 40 50 60
        //Console.WriteLine(); // new line

        //Console.WriteLine($"Number Of Items : {numbers.Count}");

        //numbers.Remove(11);
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 5 10 12 15 18 20 30 40 50 60
        //Console.WriteLine(); // new line

        //numbers.RemoveAt(0);
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 10 12 15 18 20 30 40 50 60
        //Console.WriteLine(); // new line

        //numbers.RemoveRange(0, 4);
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} ");
        //} // 20 30 40 50 60
        //Console.WriteLine(); // new line

        //bool b1 = numbers.Contains(10);
        //Console.WriteLine($"Does 10 exists in collection : {b1}"); // false

        //b1 = numbers.Contains(40);
        //Console.WriteLine($"Does 40 exists in collection : {b1}"); // true

        //numbers.Clear();
        //Console.WriteLine($"Number Of Items : {numbers.Count}"); // 0

        #endregion ArrayList

        #region Hashtable

        //Hashtable students = new Hashtable();
        //students.Add(1, "Vishal");
        //students.Add(2, "Mahesh");
        //students.Add(3, "Shital");

        //foreach (DictionaryEntry item in students)
        //{
        //    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
        //}

        //Console.WriteLine($"Number of items : {students.Count}");

        //object v1 = students[2];
        //Console.WriteLine(v1); // Mahesh

        //if (students.ContainsKey(3))
        //{
        //    Console.WriteLine($"Key {3} already exists");
        //}
        //else
        //{
        //    students.Add(3, "Snehal");
        //}        

        //foreach (DictionaryEntry item in students)
        //{
        //    Console.WriteLine($"Key : {item.Key} Value : {item.Value}");
        //}

        #endregion Hashtable

        #region Stack

        //Stack stack = new Stack();
        //stack.Push(10);
        //stack.Push(20);
        //stack.Push(30);

        //Console.WriteLine($"Number of items : {stack.Count}");

        //// object o1 = stack.Pop(); // removes & return last item from collection
        //object o1 = stack.Peek(); // return last item from collection
        //Console.WriteLine($"{o1}");

        //Console.WriteLine($"Number of items : {stack.Count}");

        #endregion Stack

        #region Queue 

        //Queue queue = new Queue();
        //queue.Enqueue(10);
        //queue.Enqueue(20);
        //queue.Enqueue(30);

        //Console.WriteLine($"Number of items : {queue.Count}");

        ////object v1 = queue.Dequeue(); // return & remove first item from collection
        //object v1 = queue.Peek(); // return first item from collection
        //Console.WriteLine(v1); // 10

        //Console.WriteLine($"Number of items : {queue.Count}");

        //v1 = queue.Dequeue(); 
        //Console.WriteLine(v1); // 10

        //v1 = queue.Dequeue();
        //Console.WriteLine(v1); // 20

        //v1 = queue.Dequeue();
        //Console.WriteLine(v1); // 30

        #endregion Queue

        Console.ReadLine();
    }
}