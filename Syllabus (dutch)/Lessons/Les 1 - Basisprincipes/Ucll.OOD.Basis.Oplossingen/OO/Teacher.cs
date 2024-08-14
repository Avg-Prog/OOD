namespace OO;

internal class Teacher : Person, ITeacher
{
    public string Teachernumber { get ; set ; }

    public override string SendMessage()
    {
        return "Welkom";
    }
}
