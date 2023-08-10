class Program
{
    static void Main()
    {
        var trainers = new Trainer().GetTrainers();
        Console.WriteLine("** ALL TRAINERS **");
        foreach (var item in trainers)
        {
            Console.WriteLine($"Id : {item.TrainerId} Name : {item.TrainerName} Gender : {item.Gender}");
        }

        var students = new Student().GetStudents();
        Console.WriteLine("** ALL STUDENTS **");
        foreach (var item in students)
        {
            Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.StudentName} " +
                $"Gender : {item.Gender} Trainer Id : {item.TrainerId}");
        }

        Console.WriteLine("** Join Method **");

        //var result1 = students.Join(trainers, 
        //     s => s.TrainerId, 
        //     t => t.TrainerId,
        //     (s1, t1) => 
        //     new { StudentName = s1.StudentName, TrainerName = t1.TrainerName });

        var result1 = from s in students
                      join t in trainers
                      on s.TrainerId equals t.TrainerId
                      select new
                      { StudentName = s.StudentName, TrainerName = t.TrainerName };

        foreach (var item in result1)
        {
            Console.WriteLine($"Student Name : {item.StudentName} : " +
                $"Trainer Name : {item.TrainerName}");
        }

        Console.WriteLine("** GroupJoin Method **");

        //var result2 = students.GroupJoin(trainers, 
        //    s => s.TrainerId, 
        //    t => t.TrainerId, 
        //    (s1, t1) =>
        //    new { StudentName = s1.StudentName, 
        //        TrainerName = t1.SingleOrDefault(t => t.TrainerId == s1.TrainerId)?.TrainerName });

        var result2 = from s in students
                      join t in trainers
                      on s.TrainerId equals t.TrainerId
                      into temp
                      from t1 in temp.DefaultIfEmpty()
                      select new
                      {
                          StudentName = s.StudentName,
                          TrainerName = t1?.TrainerName
                      };

        foreach (var item in result2)
        {
            Console.WriteLine($"Student Name : {item.StudentName} : " +
                $"Trainer Name : {item.TrainerName}");
        }

        Console.WriteLine("** Common & UnCommon Trainers **");
        var result3 = from t in trainers
                      join s in students
                      on t.TrainerId equals s.TrainerId
                      into temp
                      from s1 in temp.DefaultIfEmpty()
                      select new
                      {
                          StudentName = s1?.StudentName,
                          TrainerName = t.TrainerName
                      };

        foreach (var item in result3)
        {
            Console.WriteLine($"Student Name : {item.StudentName} : " +
                $"Trainer Name : {item.TrainerName}");
        }

        Console.WriteLine("** Full Join **");

        var result5 = result2.Union(result3);
        foreach (var item in result5)
        {
            Console.WriteLine($"Student Name : {item.StudentName} : " +
                $"Trainer Name : {item.TrainerName}");
        }

        Console.WriteLine("CROSS JOIN");

        var result4 = from s in students
                      from t in trainers
                      select new
                      {
                          StudentName = s.StudentName,
                          TrainerName = t.TrainerName
                      };
        foreach (var item in result4)
        {
            Console.WriteLine($"Student Name : {item.StudentName} : " +
                $"Trainer Name : {item.TrainerName}");
        }

        Console.ReadLine();
    }
}

class Trainer
{
    public int TrainerId { get; set; }
    public string TrainerName { get; set; }
    public string Gender { get; set; }

    public List<Trainer> GetTrainers()
    {
        return new List<Trainer>()
        {
        new Trainer(){ TrainerId = 1, TrainerName = "Vikul", Gender = "Male"},
        new Trainer(){ TrainerId = 2, TrainerName = "Usha", Gender = "Female"},
        new Trainer(){ TrainerId = 3, TrainerName = "Atul", Gender = "Male"}
        };
    }
}

class Student
{
    public int RollNumber { get; set; }
    public string StudentName { get; set; }
    public string Gender { get; set; }
    // public int? TrainerId { get; set; }
    public int? TrainerId = 1;

    public List<Student> GetStudents()
    {
        return new List<Student>()
        {
        new Student(){ RollNumber = 1, StudentName = "Vishal", Gender = "Male", TrainerId = 1},
        new Student(){ RollNumber = 2, StudentName = "Shital", Gender = "Female", TrainerId = 1},
        new Student(){ RollNumber = 3, StudentName = "Mahesh", Gender = "Male", TrainerId = 2},
        new Student(){ RollNumber = 4, StudentName = "Dipak", Gender = "Male", TrainerId = null},
        new Student(){ RollNumber = 5, StudentName = "Snehal", Gender = "Female", TrainerId = null}
        };
    }
}