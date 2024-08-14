namespace Factory;

public class StarTitle : ITitleElement
{
    public void PrintTitle(string title)
    {
        Console.WriteLine($"*** {title} ***");
    }
}
