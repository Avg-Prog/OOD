using OO;

Student studentA = new Student { Firstname = "Peter", Name = "Selie", Studentnumber = "u001" };
Teacher teacherA = new Teacher { Firstname = "Karel", Name = "Karelson", Teachernumber = "t001" };
Console.WriteLine(studentA.SendMessage());
Console.WriteLine(teacherA.SendMessage());