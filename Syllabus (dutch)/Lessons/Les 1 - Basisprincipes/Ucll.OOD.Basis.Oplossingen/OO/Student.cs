namespace OO;

internal class Student : Person, IStudent
{
    public string Studentnumber { get; set; }

    public override string SendMessage()
    {
        return "Hallo";
    }
}
