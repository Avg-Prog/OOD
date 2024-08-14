namespace OO;

internal class TeacherAndStudent : Person, IStudent, ITeacher
{
    public string Teachernumber { get; set; }
    public string Studentnumber { get; set; }

    public override string SendMessage()
    {
        return "Hallo";
    }
}
