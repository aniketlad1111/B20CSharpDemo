using VHaaShNamespace;
class Program
{
    static void Main()
    {
        #region ToString(), GetType()
        //bool b1 = true;
        //Console.WriteLine(b1.ToString());
        //Type bt1 = b1.GetType();
        //Console.WriteLine(bt1.FullName);
        //Console.WriteLine(bt1.Name);

        //int i1 = 10;
        //Console.WriteLine(i1.ToString());
        //Console.WriteLine(i1.GetType().Name);

        //string s1 = "Anil";
        //Console.WriteLine(s1.GetType().Name);

        //Student s2 = new Student("Rahul" ,"Rathod");
        //Console.WriteLine(s2.ToString()); //Student

        //Student s3 = new Student("Rahul", "Rathod");
        //Console.WriteLine(s3.ToString()); // Student

        //Console.WriteLine(s3.GetType().Name); // Student
        //Console.WriteLine(s3.GetType().FullName); // VHaaShNamespace.Student

        //Type st1 = typeof(Student);
        //Console.WriteLine(st1.Name); // Student
        //Console.WriteLine(st1.FullName); // VHaaShNamespace.Student

        //s3.Print(typeof(Student));
        //s3.Print(s3.GetType());

        #endregion ToString(), GetType()

        #region Equals()
        //int i = 10;
        //int j = 10;
        //if(i.Equals(j))
        //{
        //    Console.WriteLine("i & j are EQUAL");
        //}
        //else
        //{
        //    Console.WriteLine("i & j are NOT EQUAL");
        //}

        //string x = "Vishal";
        //string y = "Vishal";
        //if (x.Equals(y))
        //{
        //    Console.WriteLine("x & y are EQUAL");
        //}
        //else
        //{
        //    Console.WriteLine("x & y are NOT EQUAL");
        //}

        //Student s1 = new Student("Anil", "Rathod");
        ////Student s2 = s1;
        //Student s2 = new Student("Anil", "Rathod");
        //if (s1.Equals(s2))
        //{
        //    Console.WriteLine("s1 & s2 are EQUAL");
        //}
        //else
        //{
        //    Console.WriteLine("s1 & s2 are NOT EQUAL");
        //}

        #endregion Equals()

        int i = 10;
        Console.WriteLine(i.GetHashCode());

        string s = "Vishal";
        Console.WriteLine(s.GetHashCode());

        string s1 = "Mahesh";
        Console.WriteLine(s1.GetHashCode());

        Student o1 = new Student("Anil", "Rathod");
        Console.WriteLine(o1.GetHashCode());
        Student o2 = new Student("Anil", "Rathod");
        Console.WriteLine(o2.GetHashCode());



        Console.ReadLine();
    }
}

namespace VHaaShNamespace
{
    class Student
    {
        string FirstName;
        string LastName;
        public Student(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public void Print(Type type)
        {

        }

        public override bool Equals(object? obj)
        {
            Student s = (Student)obj;
            return this.FirstName.Equals(s.FirstName) &&
                this.LastName.Equals(s.LastName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.LastName.GetHashCode();
        }
    }
}
