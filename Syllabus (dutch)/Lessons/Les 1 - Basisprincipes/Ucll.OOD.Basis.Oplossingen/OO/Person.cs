namespace OO;

internal class Person
{
    public string Firstname { get; set; }
    public string Name { get; set; }

    public virtual string SendMessage()
    {
        return "";
    }
}
